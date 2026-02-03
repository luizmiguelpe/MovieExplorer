using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    public class Filme
    {
        public string Titulo { get; set; }
        public string Ano { get; set; }
        public string Genero { get; set; }
        public string Diretor { get; set; }
        public string Atores { get; set; }
        public string Avaliacao { get; set; }
        public string Sinopse { get; set; }
        public string PosterUrl { get; set; }
        public string ImdbID { get; set; }

        public string TrailerUrl => $"https://www.youtube.com/results?search_query={Uri.EscapeDataString(Titulo + " trailer")}";

        public override string ToString() => $"{Titulo} ({Ano})";
    }
}
