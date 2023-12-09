using Screen_Sound.Controllers;
using Screen_Sound.Models;

namespace Screen_Sound.UI.Menus;

internal class MenuCadastrarAlbum : MenuBase
{
    private readonly BandaController bandaController = new();
    private readonly AlbumController albumController = new();

    public override void Exibir()
    {
        ExibirTituloDoMenu("Registro de Álbum");

        if (bandaController.QtdBandasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma banda registrada!");
            return;
        }

        ScreenSoundUI.EscreverFormatado("Digite o nome da álbum: ", pularLinha: false);
        string nomeDoAlbum = Console.ReadLine()!;

        ScreenSoundUI.EscreverFormatado("Digite o nome da banda: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        Banda? banda = bandaController.PesquisarBandaPorNome(nomeDaBanda);

        if(banda is null)
        {
            ScreenSoundUI.EscreverFormatado($"A Banda '{nomeDaBanda}' não foi encontrada!");
            return;
        }

        Album novoAlbum = new(nomeDoAlbum, banda);
        
        albumController.CadastrarAlbum(novoAlbum);  
        
        ScreenSoundUI.EscreverFormatado($"O álbum '{novoAlbum.Nome}' foi registrada com sucesso!");
    }
}