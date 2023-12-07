class Musica
{
    public string Nome { get; set; }
    public Album Album { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"Música: {Nome}, Álbum: {Album.Nome}"; 

    public Musica(Album album)
    {
        this.Album = album;
    }


    public void ExibirFichaTecnica()
    {
        ScreenSoundUI.EscreverFormatado($"\t\tNome: {Nome}.");
        ScreenSoundUI.EscreverFormatado($"\t\tÁlbum: {Album.Nome}.");
        ScreenSoundUI.EscreverFormatado($"\t\tDuração: {Duracao} s.");

        if (Disponivel)
        {
            ScreenSoundUI.EscreverFormatado("\t\tDisponível no plano.");
        }
        else
        {
            ScreenSoundUI.EscreverFormatado("\t\tAdiquira o plano Plus+.");
        }
    }
}