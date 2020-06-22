using AutoMapper;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<KorisniciUpsertRequest, Database.Korisnici>().ReverseMap();
            CreateMap<DrzaveUpsertRequest, Database.Drzave>().ReverseMap();
            CreateMap<Model.Drzave, Database.Drzave>().ReverseMap();
            CreateMap<Model.Filmovi, Database.Filmovi>().ReverseMap();
            CreateMap<FilmoviUpsertRequest, Database.Filmovi>().ReverseMap();
            CreateMap<FilmskeLicnostiUpsertRequest, Database.FilmskeLicnosti>().ReverseMap();
            CreateMap<Model.FilmskeLicnosti, Database.FilmskeLicnosti>().ReverseMap();
            CreateMap<FilmoviZanroviUpsertRequest, Database.FilmoviZanrovi>().ReverseMap();
            CreateMap<Model.FilmoviZanrovi, Database.FilmoviZanrovi>().ReverseMap();
            CreateMap<ZanroviUpsertRequest, Database.Zanrovi>().ReverseMap();
            CreateMap<Model.Zanrovi, Database.Zanrovi>().ReverseMap();
            CreateMap<FilmskeUlogeUpsertRequest, Database.FilmskeUloge>().ReverseMap();
            CreateMap<Model.FilmskeUloge, Database.FilmskeUloge>().ReverseMap();
            CreateMap<ProjekcijeUpsertRequest, Database.Projekcije>().ReverseMap();
            CreateMap<Model.Projekcije, Database.Projekcije>().ReverseMap();
            CreateMap<SaleUpsertRequest, Database.Sale>().ReverseMap();
            CreateMap<Model.Sale, Database.Sale>().ReverseMap();
            CreateMap<Model.Uloge, Database.Uloge>().ReverseMap();
            CreateMap<Model.KorisnickeUloge, Database.KorisnickeUloge>().ReverseMap();
            CreateMap<RezervacijeUpsertRequest, Database.Rezervacije>().ReverseMap();
            CreateMap<Model.Rezervacije, Database.Rezervacije>().ReverseMap();
            CreateMap<Model.Gledaoci, Database.Gledaoci>().ReverseMap();
            CreateMap<GledaociUpsertRequest, Database.Gledaoci>().ReverseMap();
            CreateMap<Model.Novosti, Database.Novosti>().ReverseMap();
            CreateMap<NovostiUpsertRequest, Database.Novosti>().ReverseMap();
            CreateMap<Model.VrsteProjekcije, Database.VrsteProjekcije>().ReverseMap();
            CreateMap<VrsteProjekcijeUpsertRequest, Database.VrsteProjekcije>().ReverseMap();
            CreateMap<Model.Sjedista, Database.Sjedista>().ReverseMap();
            CreateMap<SjedistaUpsertRequest, Database.Sjedista>().ReverseMap();
            CreateMap<Model.Ulaznice, Database.Ulaznice>().ReverseMap();
            CreateMap<UlazniceUpsertRequest, Database.Ulaznice>().ReverseMap();
            CreateMap<Model.Pretplate, Database.Pretplate>().ReverseMap();
            CreateMap<PretplateUpsertRequest, Database.Pretplate>().ReverseMap();
            CreateMap<Model.Ocjene, Database.Ocjene>().ReverseMap();
            CreateMap<OcjeneUpsertRequest, Database.Ocjene>().ReverseMap();
            CreateMap<Model.Gledaoci, Database.Korisnici>().ReverseMap();
            CreateMap<Model.Korisnici, Database.Gledaoci>().ReverseMap();
            CreateMap<Model.FilmoviFilmskeLicnosti, Database.FilmoviFilmskeLicnosti>().ReverseMap();
            CreateMap<FilmoviFilmskeLicnostiUpsertRequest, Database.FilmoviFilmskeLicnosti>().ReverseMap();
            CreateMap<Model.Notifikacije, Database.Notifikacije>().ReverseMap();
            CreateMap<NotifikacijeUpsertRequest, Database.Notifikacije>().ReverseMap();
        }
    }
}
