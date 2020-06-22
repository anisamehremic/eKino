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
    public class RezervacijeService : BaseCRUDService<Model.Rezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijeService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Rezervacije> Get(RezervacijeSearchRequest search)
        {
            var query = _context.Rezervacije.Include(a => a.Gledalac).Include(a=>a.Projekcija).Include(a => a.Projekcija.Film).Include(a => a.Projekcija.Sala).AsQueryable();
            if (search.DatumRezervacije.HasValue)
            {
                query = query.Where(a => a.DatumRezervacije.Day == search.DatumRezervacije.Value.Day && a.DatumRezervacije.Month == search.DatumRezervacije.Value.Month
                    && a.DatumRezervacije.Year == search.DatumRezervacije.Value.Year);
            }
            if (search.Username != null)
            {
                query = query.Where(a => a.Gledalac.KorisnickoIme == search.Username);
            }
            return _mapper.Map<List<Model.Rezervacije>>(query);
        }

        public override Model.Rezervacije GetById(int Id)
        {
            var obj = _context.Rezervacije.Include(x => x.Gledalac).Include(a => a.Projekcija.Film).Include(a => a.Projekcija.Sala).Where(x => x.RezervacijaId == Id).FirstOrDefault();
            return _mapper.Map<Model.Rezervacije>(obj);
        }

        public override Model.Rezervacije Update(int Id, RezervacijeUpsertRequest request)
        {
            if (!request.mobilna)
            {
                var rezervacija = _context.Rezervacije.Where(a => a.RezervacijaId == Id).FirstOrDefault();
                var ulaznice = _context.Ulaznice.Where(a => a.RezervacijaId == rezervacija.RezervacijaId).ToList();

                if (request.Status == true)
                {
                    //obrisi stare dodaj nove
                    foreach (var item in ulaznice)
                    {
                        _context.Ulaznice.Remove(item);
                    }
                    _mapper.Map(request, rezervacija);
                    _context.SaveChanges();

                }
                else {
                    //stare na false
                    foreach (var item in ulaznice)
                    {
                       var tiket = _context.Ulaznice.Find(item.UlaznicaId);
                        tiket.Status = false;
                    }
                    _context.SaveChanges();
                }



                if (request.requestsUlaznice != null && request.Status)//ako je rezervacija aktivna
                {
                    foreach (var item in request.requestsUlaznice)
                    {
                        var ulaznica = _mapper.Map<Database.Ulaznice>(item);
                        ulaznica.Qrcode = GenerisiQR(item.QRtekst);
                        _context.Ulaznice.Add(ulaznica);
                    }
                    _context.SaveChanges();
                }

                return _mapper.Map<Model.Rezervacije>(rezervacija);
            }
            else
            {
                var rezervacija = _context.Rezervacije.Where(a => a.RezervacijaId == Id).FirstOrDefault();
                _mapper.Map(request, rezervacija);
                _context.SaveChanges();
                return _mapper.Map<Model.Rezervacije>(rezervacija);
            }
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

    }

}
