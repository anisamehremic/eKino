using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using eKino.WebAPI.Security;
using eKino.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace eKino.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(x => x.Filters.Add<ErrorFilter>());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Reader API",
                        Version = "V1",
                    });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                        {
                            {
                                new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "basic" }
                                }, new string[] { } }
                        });

            });
            services.AddAutoMapper(typeof(Startup));

            //var connection = @"Server=.;Database=eKino;Trusted_Connection=True;ConnectRetryCount=0";
            var connection = Configuration.GetConnectionString("eKino");
            services.AddDbContext<eKinoContext>(options => options.UseSqlServer(connection));

            services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IPreporukeService, PreporukeService>();
            services.AddScoped<ICRUDService<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest>, BaseCRUDService<Model.Drzave, object, Database.Drzave, DrzaveUpsertRequest, DrzaveUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Sjedista, SjedistaSearchRequest, SjedistaUpsertRequest, SjedistaUpsertRequest>, SjedistaServices>();
            services.AddScoped<ICRUDService<Model.Ulaznice, UlazniceSearchRequest, UlazniceUpsertRequest, UlazniceUpsertRequest>, UlazniceServices>();
            services.AddScoped<ICRUDService<Model.VrsteProjekcije, object, VrsteProjekcijeUpsertRequest, VrsteProjekcijeUpsertRequest>, BaseCRUDService<Model.VrsteProjekcije, object, Database.VrsteProjekcije, VrsteProjekcijeUpsertRequest, VrsteProjekcijeUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.FilmoviFilmskeLicnosti, object, FilmoviFilmskeLicnostiUpsertRequest, FilmoviFilmskeLicnostiUpsertRequest>, FilmoviFilmskeLicnostiService>();
            services.AddScoped<ICRUDService<Model.Filmovi, FilmoviSearchRequest, FilmoviUpsertRequest, FilmoviUpsertRequest>, FilmoviService>();
            services.AddScoped<ICRUDService<Model.FilmskeLicnosti, FilmskeLicnostiSearchRequest, FilmskeLicnostiUpsertRequest, FilmskeLicnostiUpsertRequest>, FilmskeLicnostiService>();
            services.AddScoped<ICRUDService<Model.FilmskeUloge, object, FilmskeUlogeUpsertRequest, FilmskeUlogeUpsertRequest>, BaseCRUDService<Model.FilmskeUloge, object, Database.FilmskeUloge, FilmskeUlogeUpsertRequest, FilmskeUlogeUpsertRequest>>();
            //services.AddScoped<ICRUDService<Model.Projekcije, object, ProjekcijeUpsertRequest, ProjekcijeUpsertRequest>, BaseCRUDService<Model.Projekcije, object, Database.Projekcije, ProjekcijeUpsertRequest, ProjekcijeUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Projekcije, ProjekcijeSearchRequest, ProjekcijeUpsertRequest, ProjekcijeUpsertRequest>, ProjekcijeService>();
            services.AddScoped<ICRUDService<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>, RezervacijeService>();
            services.AddScoped<ICRUDService<Model.Sale, object, SaleUpsertRequest, SaleUpsertRequest>, BaseCRUDService<Model.Sale, object, Database.Sale, SaleUpsertRequest, SaleUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Zanrovi, object, ZanroviUpsertRequest, ZanroviUpsertRequest>, BaseCRUDService<Model.Zanrovi, object, Database.Zanrovi, ZanroviUpsertRequest, ZanroviUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.Novosti, NovostiSearchRequest, NovostiUpsertRequest, NovostiUpsertRequest>, NovostiService>();
            services.AddScoped<ICRUDService<Model.FilmoviZanrovi, FilmoviZanroviSearchRequest, FilmoviZanroviUpsertRequest, FilmoviZanroviUpsertRequest>, FilmoviZanroviService>();
            services.AddScoped<ICRUDService<Model.Ocjene, OcjeneSearchRequest, OcjeneUpsertRequest, OcjeneUpsertRequest>, OcjeneService>();
            services.AddScoped<ICRUDService<Model.Pretplate, PretplateSearchRequest, PretplateUpsertRequest, PretplateUpsertRequest>, PretplateService>();
            services.AddScoped<ICRUDService<Model.Pretplate, object, PretplateUpsertRequest, PretplateUpsertRequest>, BaseCRUDService<Model.Pretplate, object, Database.Pretplate, PretplateUpsertRequest, PretplateUpsertRequest>>();
            //services.AddScoped<ICRUDService<Model.FilmoviFilmskeLicnosti, object, FilmoviFilmskeLicnostiUpsertRequest, FilmoviFilmskeLicnostiUpsertRequest>, BaseCRUDService<Model.FilmoviFilmskeLicnosti, object, Database.FilmoviFilmskeLicnosti, FilmoviFilmskeLicnostiUpsertRequest, FilmoviFilmskeLicnostiUpsertRequest>>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloge>>();
            services.AddScoped<ICRUDService<Model.Gledaoci, GledaociSearchRequest, GledaociUpsertRequest, GledaociUpsertRequest>, GledaociService>();
            services.AddScoped<ICRUDService<Model.Notifikacije, NotifikacijeSearchRequest, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>, NotifikacijeService>();
            services.AddScoped<IService<Model.KorisnickeUloge, object>, BaseService<Model.KorisnickeUloge, object, Database.KorisnickeUloge>>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRegistracijaService, RegistracijaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
