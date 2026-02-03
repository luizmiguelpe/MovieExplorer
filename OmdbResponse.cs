using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjetoFinal
{
    public class OmdbResponse
    {
        [JsonProperty("Title")] public string Title { get; set; }
        [JsonProperty("Year")] public string Year { get; set; }
        [JsonProperty("Genre")] public string Genre { get; set; }
        [JsonProperty("Director")] public string Director { get; set; }
        [JsonProperty("Actors")] public string Actors { get; set; }
        [JsonProperty("imdbRating")] public string imdbRating { get; set; }
        [JsonProperty("Plot")] public string Plot { get; set; }
        [JsonProperty("Poster")] public string Poster { get; set; }
        [JsonProperty("imdbID")] public string imdbID { get; set; }
        [JsonProperty("Response")] public string Response { get; set; }
    }
}
