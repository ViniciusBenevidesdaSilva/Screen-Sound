class AlbumController
{
    private readonly AlbumService albumService;
    private readonly BandaService bandaService;

    public AlbumController()
    {
        albumService = AlbumService.Instance;
        bandaService = BandaService.Instance;
    }

    public void SolicitarCadastroDeAlbum()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Registro de Álbum");

        if (bandaService.QtdBandasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma banda registrada!");
            return;
        }

        ScreenSoundUI.EscreverFormatado("Digite o nome da álbum: ", pularLinha: false);
        string nomeDoAlbum = Console.ReadLine()!;

        ScreenSoundUI.EscreverFormatado("Digite o nome da banda: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        Banda? banda = bandaService.PesquisarBandaPorNome(nomeDaBanda);

        if (banda is not null)
        {
            Album novoAlbum = new Album(banda);
            novoAlbum.Nome = nomeDoAlbum;

            albumService.RegistrarAlbum(novoAlbum);

            banda.AdicionarAlbum(novoAlbum);

            ScreenSoundUI.EscreverFormatado($"O álbum '{novoAlbum.Nome}' foi registrada com sucesso!");
        }
        else
        {
            ScreenSoundUI.EscreverFormatado($"A Banda '{nomeDaBanda}' não foi encontrada!");
        }
    }

    internal void MostrarAlbunsRegistrados()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Listagem de Álbuns Registrados");

        if (albumService.QtdAlbunsRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhum álbum cadastrado!");
        }
        else
        {
            foreach (Album album in albumService.AlbunsRegistrados)
            {
                ScreenSoundUI.EscreverFormatado(album.DescricaoResumida);
            }
        }
    }
}