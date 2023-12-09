namespace Screen_Sound.Models;

internal class Banda
{
    private readonly List<Avaliacao> avaliacoes = new();

    public string Nome { get; set; }
    public double AvaliacaoMedia => avaliacoes.Count == 0 ? 0 : avaliacoes.Average(a => a.Nota);
    public string DescricaoResumida => $"Banda: {Nome}, Avaliação: {AvaliacaoMedia}";
    public List<Album> Albuns { get; } = new();
    public int QtdAlbuns => Albuns.Count;


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
        Albuns.Add(album);
    }
}