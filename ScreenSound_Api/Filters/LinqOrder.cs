using ScreenSound_Api.Models;

namespace ScreenSound_Api.Filters
{
    internal class LinqOrder
    {
        public static void ExibirArtistas(List<Musica> musicas)
        {
            var artistasOrder = musicas.OrderBy(m => m.Artista)
                .Select(m => m.Artista).Distinct().ToList();

            foreach(var v in artistasOrder)
            {
                Console.WriteLine($"- {v}");
            }
        }
    }
}
