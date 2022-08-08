using IntegrationAPIOnShow.Core.Extensions;
using IntegrationAPIOnShow.Data;
using IntegrationAPIOnShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationAPIOnShow.Services
{
    public class MainServices : SingleResponse
    {
        private readonly OnShowContext _onShowContext;

        public MainServices(OnShowContext onShowContext)
        {
            _onShowContext = onShowContext;
        }
        public async Task<IActionResult> GetCarousel()
        {
            var filmesCarrossel = await _onShowContext.Carrossel.ToListAsync();
            var response = new List<GetCarouselResponse>();

            foreach (var filmes in filmesCarrossel)
                response.Add(filmes);

            return SucessResponse(response);
        }

        public async Task<IActionResult> Search(GetSearchRequest request)
        {
            var filmes = await _onShowContext.Filmes.Where(v => v.Titulo.Contains(request.Message)).ToListAsync();
            var response = new List<GetSearchResponse>();

            foreach (var filme in filmes)
                response.Add(filme);

            return SucessResponse(response);
        }

        public async Task<IActionResult> GetPopulares()
        {
            var filmes = await _onShowContext.Populares.ToListAsync();
            var response = new List<GetPopularesResponse>();

            foreach (var filme in filmes)
                response.Add(filme);

            return SucessResponse(response);
        }

        public async Task<IActionResult> GetSeries()
        {
            var series = await _onShowContext.Series.ToListAsync();
            var response = new List<GetSeriesResponse>();

            foreach (var serie in series)
                response.Add(serie);

            return SucessResponse(response);
        }

        public async Task<IActionResult> GetSeriesEp(GetSeriesEpRequest request)
        {
            var episodios = await _onShowContext.SeriesEp.Where(x => x.SeriesId.Equals(request.IdSerie)).ToListAsync();
            var response = new List<GetSeriesEpResponse>();

            foreach (var ep in episodios)
                response.Add(ep);

            return SucessResponse(response);
        }
    
        public async Task<IActionResult> GetLastFilmes()
        {
            var lastFilmes = _onShowContext.Filmes.OrderByDescending(x => x.Id).Take(18);
            if (lastFilmes == null)
                return ErrorResponse("Ocorreu algum erro, solicite ajuda!");

            var lstFilmes = new List<GetFilmesResponse>();

            foreach (var filme in lastFilmes)
                lstFilmes.Add(filme);

            return SucessResponse(lstFilmes);
        }
    }
}
