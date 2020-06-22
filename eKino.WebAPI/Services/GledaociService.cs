using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using eKino.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class GledaociService : BaseCRUDService<Model.Gledaoci, GledaociSearchRequest, Database.Gledaoci, GledaociUpsertRequest, GledaociUpsertRequest>
    {
        public GledaociService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
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


        public override Model.Gledaoci Insert(GledaociUpsertRequest request)
        {
            if (request.Sifra != request.SifraPotvrda)
            {
                throw new UserException("Šifre se ne slažu");
            }
            var obj = _mapper.Map<Database.Gledaoci>(request);
            obj.LozinkaSalt = GenerateSalt();
            obj.LozinkaHash = GenerateHash(obj.LozinkaSalt, request.Sifra);
            _context.Gledaoci.Add(obj);
            _context.SaveChanges();

            _context.SaveChanges();
            return _mapper.Map<Model.Gledaoci>(obj);

        }
        public override List<Model.Gledaoci> Get(GledaociSearchRequest search)
        {
            var query = _context.Gledaoci.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search.Username))
            {
                query = query.Where(a => a.KorisnickoIme.Equals(search.Username));
            }
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(a => a.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(a => a.Prezime.StartsWith(search.Prezime));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Gledaoci>>(list);
        }

        public override Model.Gledaoci Update(int Id, GledaociUpsertRequest request)
        {
            if (!request.Mobilna)
            {
                var obj = _context.Gledaoci.Find(Id);
                _mapper.Map(request, obj);
                if ((!string.IsNullOrWhiteSpace(request.Sifra)) && (request.Sifra == request.SifraPotvrda))
                {
                    obj.LozinkaSalt = GenerateSalt();
                    obj.LozinkaHash = GenerateHash(obj.LozinkaSalt, request.Sifra);
                }
                else
                {
                    throw new UserException("Nemoguće promijeniti šifru.");
                }
                _context.SaveChanges();
                return _mapper.Map<Model.Gledaoci>(obj);
            }
            else
            {
                var obj = _context.Gledaoci.Find(Id);

                var sifraProvjera = GenerateHash(obj.LozinkaSalt, request.StaraSifra);
                if (sifraProvjera != obj.LozinkaHash)
                {
                    throw new Exception("Niste unijeli ispravnu trenutnu šifru.");
                }

                _mapper.Map(request, obj);

                if ((!string.IsNullOrWhiteSpace(request.Sifra)) && (request.Sifra == request.SifraPotvrda))
                {
                    obj.LozinkaSalt = GenerateSalt();
                    obj.LozinkaHash = GenerateHash(obj.LozinkaSalt, request.Sifra);
                }
                else
                {
                    throw new UserException("Niste unijeli ispravne podatke.");
                }

                _context.SaveChanges();
                return _mapper.Map<Model.Gledaoci>(obj);
            }
        }
    }
}
