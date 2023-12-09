namespace Screen_Sound.Models;

internal class Album
{

    public string Nome { get; set; }
    public int DuracaoTotal => Musicas.Count == 0 ? 0 : Musicas.Sum(m => m.Duracao);
    public Banda Banda { get; set; }
    public string DescricaoResumida => $"Álbum: {Nome}, Duração: {DuracaoTotal}";
    public List<Musica> Musicas { get; } = new();
    public int QtdMusicas => Musicas.Count;
    
    public Album(string nome, Banda banda)
    {
        this.Nome = nome;
        this.Banda = banda;
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
}