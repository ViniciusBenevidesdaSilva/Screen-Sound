class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");

        foreach (var musica in musicas)
        {
            musica.ExibirFichaTecnica();
        }

        Console.WriteLine($"A duração desse álbum é de {DuracaoTotal} segundos");
    }
}