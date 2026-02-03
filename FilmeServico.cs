using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace ProjetoFinal
{
    public class FilmeServico
    {

        private const string ApiKey = "9485de72";
        private static readonly HttpClient client = new HttpClient();

        public async Task<Filme> PesquisarFilmesAsync(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("O título do filme não pode ser vazio.", nameof(titulo));

            string url = $"http://www.omdbapi.com/?t={Uri.EscapeDataString(titulo)}&apikey={ApiKey}";
            string resposta = await client.GetStringAsync(url);

            if (string.IsNullOrWhiteSpace(resposta))
                throw new Exception("Resposta vazia da API.");

            var dados = JsonConvert.DeserializeObject<OmdbResponse>(resposta);

            if(dados == null || dados.Response != "True")
                return null;

            return new Filme
            {
                Titulo = dados.Title,
                Ano = dados.Year,
                Genero = dados.Genre,
                Diretor = dados.Director,
                Atores = dados.Actors,
                Avaliacao = dados.imdbRating,
                Sinopse = dados.Plot,
                PosterUrl = dados.Poster,
                ImdbID = dados.imdbID
            };
        }
    }
}
