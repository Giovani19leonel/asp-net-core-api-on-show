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
    public class FilmesNegocio : IFilmes
    {
        private DBContext _db;
        private Filmes _filmes;

        public FilmesNegocio(DBContext db, Filmes filmes)
        {
            _db = db;
            _filmes = filmes;
        }

        public string InputFilmes(FilmesDefaultModels filmes)
        {
            using (_db)
            {

                var f = _db.Filmes.FirstOrDefault(x => x.Titulo == filmes.Titulo);
                if(f == null)
                {
                    _filmes.Titulo = filmes.Titulo;
                    _filmes.Sinopse = filmes.Sinopse;
                    _filmes.Nota = filmes.Nota;
                    _filmes.Video = filmes.Video;
                    _filmes.Catalogo = filmes.Catalogo;
                    _filmes.Duracao = filmes.Duracao;
                    _filmes.Ano = filmes.Ano;
                    _filmes.Genero = filmes.Genero;
                    _db.Entry(_filmes).State = EntityState.Added;
                    _db.SaveChanges();
                    return "Filme cadastrado com sucesso";
                }
                return "Já existe um Filme com esse titulo cadastrado!";
            }
        }

        public List<FilmesDefaultModels> ObterFilmes()
        {

            var listaFilmes = new List<FilmesDefaultModels>();
            using (_db)
            {
                var filmes = _db.Filmes; // filmes recebe a tabela de Filmes do BD
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

        public FilmesDefaultModels ObterFilme(string titulo)
        {
            var filmes = _db.Filmes;
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

        public string ModificarFilme(FilmesDefaultModels film)
        {
            try { 
                var filme = _db.Filmes.FirstOrDefault(x => x.Titulo.ToLower() == film.Titulo.ToLower());
                filme.Sinopse = film.Sinopse;
                filme.Ano = film.Ano;
                filme.Genero = film.Genero;
                filme.Duracao = film.Duracao;
                filme.Nota = film.Nota;
                filme.Catalogo = film.Catalogo;
                filme.Video = film.Video;
                _db.Entry(filme).State = EntityState.Modified;
                _db.SaveChanges();
                return "Filme modificado com sucesso!";
            }
            catch
            {
                return "Erro inesperado, consulte o desenvolvedor.";
            }
        }

        public string DeletarFilme(string titulo)
        {
            using(_db)
            {
                try { 
                    var filme = _db.Filmes.FirstOrDefault(x => x.Titulo.ToLower() == titulo.ToLower());
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

    }
}
