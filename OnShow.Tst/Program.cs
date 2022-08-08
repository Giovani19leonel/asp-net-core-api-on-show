using Newtonsoft.Json;
using OnShow.Tst.Data;
using OnShow.Tst.Data.Entity;
using OnShow.Tst.Models;
using System.IO;

//var t = new GetData();
//t.InsertFilmes(t.ReadJson());
Console.WriteLine("Projeto errado!");
public class GetData
{
    public DataFileJsonModel ReadJson()
    {
        StreamReader read = new StreamReader("../../../Data/Material/dados.json");
        string jsonString = read.ReadToEnd();
        DataFileJsonModel data = JsonConvert.DeserializeObject<DataFileJsonModel>(jsonString);
        return data;
    }

    public void InsertFilmes(DataFileJsonModel data)
    {
        using(var filmes = new OnShowContext())
        {
            foreach(var descricao in data.descricao)
            {
                var filme = new Filmes()
                {
                    Titulo = descricao.titulo,
                    Sinopse = descricao.sinopse,
                    Ano = descricao.ano,
                    Genero = descricao.genero,
                    Duracao = descricao.genero,
                    Nota = descricao.nota,
                    Catalogo = descricao.catalogo,
                    Video = descricao.video
                };
                filmes.Filmes.Add(filme);
            }

            foreach(var popular in data.populares)
            {
                var filmesPopulares = new Populares()
                {
                    Titulo = popular.titulo,
                    Sinopse = popular.sinopse,
                    Ano = popular.ano,
                    Genero = popular.genero,
                    Duracao = popular.genero,
                    Nota = popular.nota,
                    Catalogo = popular.catalogo,
                    Video = popular.video
                };
                filmes.Populares.Add(filmesPopulares);
            }
            filmes.SaveChanges();
            Console.WriteLine("Finish..");
            Console.ReadLine();
        }
    }
}