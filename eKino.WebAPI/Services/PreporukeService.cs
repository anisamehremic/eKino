using AutoMapper;
using eKino.Model;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class PreporukeService : IPreporukeService
    {

        private readonly eKinoContext _context;
        private readonly IMapper _mapper;
        public int BrojPreporuka = 5;
        public PreporukeService(eKinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Projekcije> Get(int GledalacId)
        {
            List<Database.Rezervacije> rezervacijeGledaoca = _context.Rezervacije.Include(a=>a.Projekcija).Where(a => a.GledalacId == GledalacId && a.Status.Value).ToList();
            List<Database.FilmoviZanrovi> filmoviZanrovi = _context.FilmoviZanrovi.Include(a=>a.Zanr).Include(a=>a.Film).ToList();
            if (rezervacijeGledaoca.Count > 0)
            {
                var listaZanrovaIzRezervacija = new List<Database.Zanrovi>();
                foreach(var rezervacija in rezervacijeGledaoca)
                {
                    foreach(var fz in filmoviZanrovi)
                    {
                        if (rezervacija.Projekcija.FilmId == fz.FilmId)
                        {
                            if (!listaZanrovaIzRezervacija.Contains(fz.Zanr))
                                listaZanrovaIzRezervacija.Add(fz.Zanr);
                        }
                    }
                }


                var projekcije = _context.Projekcije.Include(a=>a.Film).Where(a => a.DatumVrijemeOdrzavanja > DateTime.Now);
                var ListaPreporucenihProjekcija = new List<Database.Projekcije>();
                foreach(var zanr in listaZanrovaIzRezervacija)
                {
                    foreach(var projekcija in projekcije)
                    {
                        foreach(var fz in filmoviZanrovi)
                        {
                            if (projekcija.FilmId == fz.FilmId && fz.ZanrId==zanr.ZanrId)
                            {
                                if (!ListaPreporucenihProjekcija.Contains(projekcija))
                                    ListaPreporucenihProjekcija.Add(projekcija);
                            }
                        }
                    }
                }

                ListaPreporucenihProjekcija = ListaPreporucenihProjekcija.OrderBy(a => Guid.NewGuid()).Take(BrojPreporuka).ToList();
                if (ListaPreporucenihProjekcija.Count == 0)
                {
                    ListaPreporucenihProjekcija = _context.Projekcije.Take(BrojPreporuka).ToList();
                }
                var povratna = _mapper.Map<List<Model.Projekcije>>(ListaPreporucenihProjekcija);
                return povratna;
            }

            var listaProjekcija = _context.Projekcije.OrderBy(a => Guid.NewGuid()).Take(BrojPreporuka).ToList();
            var povratna2 = _mapper.Map<List<Model.Projekcije>>(listaProjekcija);
            return povratna2;


        }
    }
}
