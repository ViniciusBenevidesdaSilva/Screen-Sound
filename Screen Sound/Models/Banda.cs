class Banda
{
    private List<int> avaliacoes = new List<int>();
    private List<Album> albums = new List<Album>();

    public string Nome { get; set; }
    public double AvaliacaoMedia => avaliacoes.Count == 0 ? 0 : avaliacoes.Average();
    public string DescricaoResumida => $"Banda: {Nome}, Avaliação: {AvaliacaoMedia}";


    public void AdicionarAvaliacao(int avaliacao)
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