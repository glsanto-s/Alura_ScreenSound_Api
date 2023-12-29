using System.Text.Json;

namespace ScreenSound_Api.Models
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaMusicasFav { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaMusicasFav = new List<Musica>();
        }

        public void AddMusicasFav(Musica musicas)
        {
            ListaMusicasFav.Add(musicas);
        }

        public void ShowMusicasFav()
        {
            Console.WriteLine("Músicas favoritas:");
            foreach(var m in ListaMusicasFav)
            {
                Console.WriteLine($"- {m.NomeMusica} de {m.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                muscias = ListaMusicasFav
            });
            string nomeArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo Json criado com sucesso! {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
