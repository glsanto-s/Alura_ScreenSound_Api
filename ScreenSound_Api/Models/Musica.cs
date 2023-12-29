using System.Text.Json.Serialization;

namespace ScreenSound_Api.Models
{
    internal class Musica
    {
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("song")]
        public string? NomeMusica { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("year")]
        public string? Ano { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }

        public string[] acordes =
        {
            "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"
        };

        public string Acorde { get { 
            return acordes[Key];
            } }

        public void ExibirDetalhesMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {NomeMusica}");
            Console.WriteLine($"Duração: {Duracao/1000}s");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Tonalidade: {Acorde}");
        }

    }
}
