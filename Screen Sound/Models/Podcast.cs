using Screen_Sound.UI;

namespace Screen_Sound.Models;

internal class Podcast
{
    private readonly List<Episodio> episodios = new();

    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios => episodios.Count;
    public string DescricaoResumida => $"Nome: {Nome}, Host: {Host}";

    public Podcast(string host, string nome)
    {
        this.Host = host;
        this.Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodio.Ordem = episodios.Count;
        episodios.Add(episodio);
    }

    public void ExibirEpisodiosDoPodcast()
    {
        ScreenSoundUI.EscreverFormatado($"\tLista de episódios do podcast '{Nome}'.\n");

        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            episodio.ExibirDetalhes();
            Console.WriteLine();
        }

        ScreenSoundUI.EscreverFormatado($"\tO Host desse podcast é {Host}, com um total de {TotalEpisodios} episódios.");
    }
}