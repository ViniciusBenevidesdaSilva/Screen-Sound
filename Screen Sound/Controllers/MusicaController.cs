class MusicaController
{
    private readonly MusicaService musicaService;
    private readonly AlbumService albumService;

    public MusicaController()
    {
        musicaService = MusicaService.Instance;
        albumService = AlbumService.Instance;
    }

    public void SolicitarCadastroDeMusica()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Registro de Música");

        if(albumService.QtdAlbunsRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhum álbum registrado!");
            return;
        }

        ScreenSoundUI.EscreverFormatado("Digite o nome da música: ", pularLinha: false);
        string nomeDaMusica = Console.ReadLine()!;

        ScreenSoundUI.EscreverFormatado("Digite a duração da música em segundos: ", pularLinha: false);
        int duracaoDaMusica = int.Parse(Console.ReadLine()!);

        ScreenSoundUI.EscreverFormatado("Digite o nome do Álbum: ", pularLinha: false);
        string nomeDoAlbum = Console.ReadLine()!;

        ScreenSoundUI.EscreverFormatado("Digite [S] se a música estiver disponível no plano, ou [N] caso contrário: ", pularLinha: false);
        bool disponivelNoPlano = Console.ReadLine()!.ToUpper()[0] == 'S';

        Album? album = albumService.PesquisarAlbumPorNome(nomeDoAlbum);

        if (album is not null)
        {
            Musica novaMusica = new Musica(album);
            novaMusica.Nome = nomeDaMusica;
            novaMusica.Duracao = duracaoDaMusica;
            novaMusica.Disponivel = disponivelNoPlano;

            musicaService.RegistrarMusica(novaMusica);

            album.AdicionarMusica(novaMusica);

            ScreenSoundUI.EscreverFormatado($"A música '{novaMusica.Nome}' foi registrada com sucesso!");
        }
        else
        {
            ScreenSoundUI.EscreverFormatado($"O Álbum '{nomeDoAlbum}' não foi encontrado!");
        }
    }

    internal void MostrarMusicasRegistradas()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Listagem de Músicas Registradas");

        if (musicaService.QtdMusicasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma música cadastrada!");
        }
        else
        {
            foreach (Musica musica in musicaService.MusicasRegistradas)
            {
                ScreenSoundUI.EscreverFormatado(musica.DescricaoResumida);
            }
        }
    }
}