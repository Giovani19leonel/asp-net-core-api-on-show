using API_OnShow.Controllers;
using API_OnShow.Data;
using API_OnShow.Entidades;
using API_OnShow.Negocio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace fodase
{
    public class Extensions
    {

        public static void Main()
        {
            var z = new Extensions();

            z.Teste();
        }

        public void Teste()
        {
            var negocio = new FilmesNegocio(new DBContext(), new Filmes());
            var filmes = new FilmesController(negocio);
            Type type = filmes.ObterFilmes().GetType();

            // var z = typeof(FilmesController).CustomAttributes.Where(x => x.Constructor.Equals(Controller)); AuthorizeAttribute
            
          /*  var x = typeof(FilmesController).GetMethods()
                .Where(x => x.DeclaringType.Name.Contains("FilmesController")
                    && x.DeclaringType.FullName.Contains("Controllers")).FirstOrDefault();

            Console.WriteLine(x.DeclaringType.DeclaringType.Name);*/

            var l = filmes is FilmesController;
            var c = filmes is Controller;
            var y = filmes is ControllerBase;


            if(filmes is ControllerBase)
            {
                var z1 = filmes.GetType().Namespace;
                var z2 = filmes.GetType().GetMethods().Where(x => x.DeclaringType.Namespace.Equals(z1)).ToList();
            }
            

            var q1 = filmes.ObterFilme("t").GetType();
            var q2 = filmes.GetType().GetMethods().ToList();

            var a = filmes.GetType().GetMethods().Where(x => x.DeclaringType.Name is FilmesController).ToList();

            

            // var f = x.Where(x => x.CustomAttributes.
            //    Any(x => x.AttributeType.Name == "AuthorizeAttribute")).ToList();

            // INTERPRETAÇÃO SUPOSTA
        }

    }
}

