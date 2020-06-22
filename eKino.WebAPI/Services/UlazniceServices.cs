using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class UlazniceServices : BaseCRUDService<Model.Ulaznice, UlazniceSearchRequest, Database.Ulaznice, UlazniceUpsertRequest, UlazniceUpsertRequest>
    {
        public UlazniceServices(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public override List<Model.Ulaznice> Get(UlazniceSearchRequest search)
        {
            var query = _context.Ulaznice.Include(a=>a.Projekcija.Film).Include(a => a.Projekcija.Sala).Include(a=>a.Sjediste).Include(x=>x.Rezervacija.Gledalac).AsQueryable();

            if (search.ProjekcijaId.HasValue && search.ProjekcijaId != 0)
            {
                query = query.Where(a => a.ProjekcijaId == search.ProjekcijaId);
            }
            if (search.GledalacId.HasValue && search.GledalacId != 0)
            {
                query = query.Where(a=>a.GledalacId==search.GledalacId);
            }
            if (search.RezervacijaId.HasValue && search.RezervacijaId != 0)
            {
                query = query.Where(a => a.RezervacijaId == search.RezervacijaId);
            }
            
            if (search.Aktivne.HasValue && search.Aktivne == true)
            {
                query = query.Where(a => a.Status == true);
            }  
            if (search.Neaktivne.HasValue && search.Neaktivne == true)
            {
                query = query.Where(a => a.Status == false);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Ulaznice>>(list);
        }
        public override Model.Ulaznice GetById(int Id)
        {
            var query = _context.Ulaznice.Include(a => a.Projekcija.Film).Include(a=>a.Projekcija.VrstaProjekcije).Include(a => a.Projekcija.Sala).Include(a => a.Sjediste).Include(x => x.Rezervacija.Gledalac).AsQueryable();
            var obj = query.Where(a=>a.UlaznicaId==Id).FirstOrDefault();
            return _mapper.Map<Model.Ulaznice>(obj);
        }
        private static byte[] GenerisiQR(string poruka)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(poruka, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap qrCodeImage = code.GetGraphic(10);
            var bitmapBytes = BitmapToBytes(qrCodeImage);
            return bitmapBytes;
        }
        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        public override Model.Ulaznice Insert(UlazniceUpsertRequest request)
        {
            var obj = _mapper.Map<Database.Ulaznice>(request);
            obj.Qrcode = GenerisiQR(request.QRtekst);
            _context.Ulaznice.Add(obj);
            _context.SaveChanges();
            return _mapper.Map<Model.Ulaznice>(obj);
        }

    }
}
