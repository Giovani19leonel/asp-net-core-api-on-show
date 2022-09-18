using API_OnShow.Data;
using API_OnShow.Entidades;
using API_OnShow.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_OnShow.Negocio
{
    public class FilmesPopularesNegocio : IFilmes
    {
        private DBContext _db;
        private Populares _populares;
        public FilmesPopularesNegocio(DBContext db, Populares populares)
        {
            _db = db;
            _populares = populares;
        }
        public string DeletarFilme(string titulo)
        {
            using (_db)
            {
                try
                {
                    var filme = _db.Populares.FirstOrDefault(x => x.Titulo.ToLower() == titulo.ToLower());
                    _db.Entry(filme).State = EntityState.Deleted;
                    _db.SaveChanges();
                    return "Filme removido com sucesso";
                }
                catch
                {
                    return "Erro inesperado, consulte o desenvolvedor.";
                }
            }
        }
    
        public string InputFilmes(string titulo)
        {
            
            using(_db)
            {
                var filmes = _db.Filmes;
                try 
                { 
                    var registro = filmes.FirstOrDefault(x => x.Titulo.ToLower() == titulo.ToLower());
                    if (registro != null)
                    {
                        _populares.Titulo = registro.Titulo;
                        _populares.Sinopse = registro.Sinopse;
                        _populares.Ano = registro.Ano;
                        _populares.Genero = registro.Genero;
                        _populares.Duracao = registro.Duracao;
                        _populares.Nota = registro.Nota;
                        _populares.Catalogo = registro.Catalogo;
                        _populares.Video = registro.Video;
                        _populares.FilmesId = registro.Id;
                        _db.Entry(_populares).State = EntityState.Added;
                        _db.SaveChanges();
                        return "Filme cadastrado com sucesso";
                    }
                    return "Não existe nenhum filme com esse titulo cadastrado";
                    
                }
                catch
                {
                    return "Erro inesperado";
                }
            }
        }

        public string ModificarFilme(FilmesDefaultModels f)
        {
            throw new NotImplementedException();
        }

        public FilmesDefaultModels ObterFilme(string titulo)
        {
            var filmes = _db.Populares;
            var filme = new FilmesDefaultModels();
            var registro = filmes.FirstOrDefault(x => x.Titulo.ToLower() == titulo.ToLower());
            filme.Titulo = registro.Titulo;
            filme.Sinopse = registro.Sinopse;
            filme.Ano = registro.Ano;
            filme.Genero = registro.Genero;
            filme.Duracao = registro.Duracao;
            filme.Nota = registro.Nota;
            filme.Catalogo = registro.Catalogo;
            filme.Video = registro.Video;
            return filme;
        }

        public List<FilmesDefaultModels> ObterFilmes()
        {
            var listaFilmes = new List<FilmesDefaultModels>();
            using (_db)
            {
                var filmes = _db.Populares; // filmes recebe a tabela de Filmes do BD
                listaFilmes.AddRange(filmes.Select(x => new FilmesDefaultModels
                {
                    Titulo = x.Titulo,
                    Sinopse = x.Sinopse,
                    Ano = x.Ano,
                    Genero = x.Genero,
                    Duracao = x.Duracao,
                    Nota = x.Nota,
                    Catalogo = x.Catalogo,
                    Video = x.Video
                }));
                return listaFilmes;
            }
        }
    }
}
