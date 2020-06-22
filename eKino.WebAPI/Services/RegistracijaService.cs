using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class RegistracijaService:IRegistracijaService
    {
        protected readonly eKinoContext _context;
        protected readonly IMapper _mapper;

        public RegistracijaService(eKinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
        public Model.Gledaoci Insert(GledaociUpsertRequest request)
        {
            if (request.Sifra != request.SifraPotvrda)
            {
                throw new Exception("Šifre se ne slažu.");
            }
            var obj = _mapper.Map<Database.Gledaoci>(request);
            
            obj.LozinkaSalt = GenerateSalt();
            obj.LozinkaHash = GenerateHash(obj.LozinkaSalt, request.Sifra);
            _context.Gledaoci.Add(obj);
            _context.SaveChanges();

            _context.SaveChanges();
            return _mapper.Map<Model.Gledaoci>(obj);

        }

        public List<Model.Gledaoci> Get(GledaociSearchRequest search)
        {
            var query = _context.Gledaoci.AsQueryable();
            if (search.Username != null)
            {
                query = query.Where(a => a.KorisnickoIme == search.Username);
            }
            return _mapper.Map<List<Model.Gledaoci>>(query);
        }
    }
}
