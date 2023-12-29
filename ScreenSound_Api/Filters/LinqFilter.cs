using ScreenSound_Api.Models;

namespace ScreenSound_Api.Filters
{
    internal class LinqFilter
    {
        public static void FiltrarGeneros(List<Musica> musicas)
        {
            var allGeneros = musicas.Select(g => g.Genero).Distinct().ToList();

            foreach (var g in allGeneros)
            {
                Console.WriteLine($"- {g}");
            }
        }

        public static void FiltrarArtistaGenero(List<Musica> musicas, string genero)
        {
            var artistaGenero = musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();

            foreach (var a in artistaGenero)
            {
                Console.WriteLine($"- {a}");
            }
        }

        public static void FiltrarMusicasArtista(List<Musica> musicas, string nomeArtista)
        {
            var musicasArtista = musicas.Where(m => m.Artista!.Equals(nomeArtista)).ToList();
            Console.WriteLine($"Músicas do artista: {nomeArtista}");
            foreach (var m in musicasArtista)
            {
                Console.WriteLine($"- {m.NomeMusica}");
            }
        }

        public static void FiltrarMusicasAno(List<Musica> musicas, string ano)
        {
            var musicasAno = musicas.Where(m => m.Ano!.Equals(ano)).ToList();
            Console.WriteLine($"Músicas do ano: {ano}");
            foreach (var m in musicasAno)
            {
                Console.WriteLine($"- {m.NomeMusica}");
            }
        }

        public static void FiltrarMusicaAcorde(List<Musica> musicas, string acorde)
        {
            var musicaAcorde = musicas.Where(m => m.Acorde!.Equals(acorde)).ToList();
            Console.WriteLine($"Músicas com acorde em {acorde}");
            foreach (var m in musicaAcorde)
            {
                Console.WriteLine($"- {m.NomeMusica}");
            }
        }
    }
}
