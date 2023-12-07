class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Count == 0 ? 0 : musicas.Sum(m => m.Duracao);
    public Banda Banda { get; set; }
    public string DescricaoResumida => $"Álbum: {Nome}, Duração: {DuracaoTotal}, Banda: {Banda.Nome}";


    public Album(string nome, Banda banda)
    {
        this.Nome = nome;
        this.Banda = banda;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        ScreenSoundUI.EscreverFormatado($"\tLista de músicas do álbum '{Nome}'.\n");

        foreach (var musica in musicas)
        {
            musica.ExibirFichaTecnica();
            Console.WriteLine();
        }

        ScreenSoundUI.EscreverFormatado($"\tA duração desse álbum é de {DuracaoTotal} segundos.");
    }
}