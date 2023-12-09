using Screen_Sound.UI;

namespace Screen_Sound.Models;

internal class Banda
{
    private readonly List<Avaliacao> avaliacoes = new();
    private readonly List<Album> albums = new();

    public string Nome { get; set; }
    public double AvaliacaoMedia => avaliacoes.Count == 0 ? 0 : avaliacoes.Average(a => a.Nota);
    public string DescricaoResumida => $"Banda: {Nome}, Avaliação: {AvaliacaoMedia}";

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAvaliacao(Avaliacao avaliacao)
    {
        avaliacoes.Add(avaliacao);
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirAlbums()
    {
        ScreenSoundUI.EscreverFormatado($"Lista de álbuns da banda '{Nome}'.\n");

        foreach (var album in albums)
        {
            album.ExibirMusicasDoAlbum();
            Console.WriteLine();
        }

        ScreenSoundUI.EscreverFormatado($"A avaliação dessa banda é de {AvaliacaoMedia}.");
    }
}