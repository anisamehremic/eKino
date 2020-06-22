using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using eKino.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        protected readonly eKinoContext _context;
        protected readonly IMapper _mapper;

        public KorisniciService(eKinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Model.Korisnici GetById(int Id)
        {
            var obj = _context.Korisnici.Find(Id);
            return _mapper.Map<Model.Korisnici>(obj);
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            if (request.Sifra != request.SifraPotvrda)
            {
                throw new UserException("Šifre se ne slažu");
            }
            var uloge = request.Uloge;
            var obj = _mapper.Map<Database.Korisnici>(request);
            obj.LozinkaSalt = GenerateSalt();
            obj.LozinkaHash = GenerateHash(obj.LozinkaSalt, request.Sifra);
            _context.Korisnici.Add(obj);
            _context.SaveChanges();

            foreach (var item in uloge)
            {
                Database.KorisnickeUloge nova = new Database.KorisnickeUloge()
                {
                    UlogaId = item,
                    KorisnikId = obj.KorisnikId,
                    DatumIzmjene = DateTime.Now
                };
                _context.KorisnickeUloge.Add(nova);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(obj);
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest search)
        {
            var query = _context.Korisnici.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(a => a.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(a => a.Prezime.StartsWith(search.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(search.KorisnickoIme))
            {
                query = query.Where(a => a.KorisnickoIme.Equals(search.KorisnickoIme));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici Update(int Id, KorisniciUpsertRequest request)
        {
            var obj = _context.Korisnici.Find(Id);
            _mapper.Map(request, obj);
            var ulogeBrisanje = _context.KorisnickeUloge.ToList();
            foreach (var item in ulogeBrisanje)
            {
                if (item.KorisnikId == obj.KorisnikId)
                    _context.Remove(item);
            }
            if ((!string.IsNullOrWhiteSpace(request.Sifra)) && (request.Sifra==request.SifraPotvrda))
            {
                obj.LozinkaSalt = GenerateSalt();
                obj.LozinkaHash = GenerateHash(obj.LozinkaSalt, request.Sifra);
            }
            else
            {
                throw new UserException("Nemoguće promijeniti šifru.");
            }
            _context.SaveChanges();
            foreach (var item in request.Uloge)
            {
                Database.KorisnickeUloge nova = new Database.KorisnickeUloge()
                {
                    KorisnikId = obj.KorisnikId,
                    UlogaId = item,
                    DatumIzmjene = DateTime.Now
                };
                _context.KorisnickeUloge.Add(nova);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(obj);
        }
    }
}
