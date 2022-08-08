using API_OnShow.Data;
using API_OnShow.Entidades;
using API_OnShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Negocio
{
    public class CarrosselNegocio
    {
        private DBContext _db;
        public CarrosselNegocio(DBContext db)
        {
            _db = db;
        }

        public async Task<List<FilmeCarrosselModel>> GetFilmesCarrossel()
        {
            var lstCarrossel = new List<FilmeCarrosselModel>();

            using(_db)
            {
                var filmes =  await _db.Carrossel.ToListAsync();

                foreach(var filme in filmes)
                {
                    var filmeCarrossel = new FilmeCarrosselModel
                    {

                        Titulo = filme.Titulo,
                        Ano = filme.Ano,
                        Catalogo = filme.Catalogo,
                        Nota = filme.Nota
                    };

                    lstCarrossel.Add(filmeCarrossel);
                };

                return lstCarrossel;
            }
        }

        public async Task<string> PostFilmesCarrossel(string titulo)
        {

            using(_db)
            {
                var filme = await _db.Filmes.Where(x => x.Titulo.Equals(titulo)).FirstOrDefaultAsync();

                if (filme == null)
                    return "Filme não encontrado.";
                await _db.Carrossel.AddAsync(new Carrossel()
                {
                    Titulo = filme.Titulo,
                    Ano = filme.Ano,
                    Catalogo = filme.Catalogo,
                    Nota = filme.Nota
                });

                await _db.SaveChangesAsync();
            }

            return "Filme cadastrado com sucesso!";
        }

        public async Task<string> DeleteFilmesCarrossel(string titulo)
        {
            using (_db)
            {
                var filme = await _db.Carrossel.Where(x => x.Titulo.Equals(titulo)).FirstOrDefaultAsync();

                if (filme == null)
                    return "Filme não cadastrado";
                _db.Carrossel.Remove(filme);
                await _db.SaveChangesAsync();
                
            }
                return "Filme removido com sucesso!";
        }
    }
}
