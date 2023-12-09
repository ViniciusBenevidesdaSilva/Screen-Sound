using Screen_Sound.Controllers;
using Screen_Sound.Models;

namespace Screen_Sound.UI.Menus;

internal class MenuCadastrarMusica : MenuBase
{
    readonly MusicaController musicaController = new();
    readonly AlbumController albumController = new();

    public override void Exibir()
    {
        ExibirTituloDoMenu("Registro de Música");

        if (albumController.QtdAlbunsRegistradas == 0)
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

        ScreenSoundUI.EscreverFormatado("Digite o nome do Gênero da música: ", pularLinha: false);
        string nomeDoGenero = Console.ReadLine()!;

        ScreenSoundUI.EscreverFormatado("Digite [S] se a música estiver disponível no plano, ou [N] caso contrário: ", pularLinha: false);
        bool disponivelNoPlano = Console.ReadLine()!.ToUpper()[0] == 'S';


        Album? album = albumController.PesquisarAlbumPorNome(nomeDoAlbum);

        if (album is null)
        {
            ScreenSoundUI.EscreverFormatado($"O Álbum '{nomeDoAlbum}' não foi encontrado!");
            return;
        }

        Musica novaMusica = new(nomeDaMusica, album)
        {
            Duracao = duracaoDaMusica,
            Genero = new Genero() { Nome = nomeDoGenero },
            Disponivel = disponivelNoPlano
        };


        musicaController.CadastrarMusica(novaMusica);
        
        ScreenSoundUI.EscreverFormatado($"A música '{novaMusica.Nome}' foi registrada com sucesso!");
    }
}