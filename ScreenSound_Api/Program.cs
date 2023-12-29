using ScreenSound_Api.Filters;
using ScreenSound_Api.Models;
using System.Text.Json;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string res = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(res)!;

        //LinqFilter.FiltrarGeneros(musicas);
        //LinqOrder.ExibirArtistas(musicas);
        //LinqFilter.FiltrarArtistaGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasArtista(musicas, "Adele");
        //LinqFilter.FiltrarMusicasAno(musicas, "2013");
        LinqFilter.FiltrarMusicaAcorde(musicas, "C#");

        //var musicasFav = new MusicasPreferidas("Gyo");
        //musicasFav.AddMusicasFav(musicas[123]);
        //musicasFav.AddMusicasFav(musicas[234]);
        //musicasFav.AddMusicasFav(musicas[345]);
        //musicasFav.AddMusicasFav(musicas[456]);
        //musicasFav.AddMusicasFav(musicas[578]);

        //musicasFav.ShowMusicasFav();
        //musicasFav.GerarArquivoJson();

        //musicas[17].ExibirDetalhesMusica();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
