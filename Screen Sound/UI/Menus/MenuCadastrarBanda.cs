using Screen_Sound.Controllers;
using Screen_Sound.Models;

namespace Screen_Sound.UI.Menus;

internal class MenuCadastrarBanda : MenuBase
{
    private readonly BandaController bandaController = new();


    public override void Exibir()
    {
        ExibirTituloDoMenu("Registro de Banda");

        ScreenSoundUI.EscreverFormatado("Digite o nome da banda: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        Banda novaBanda = new(nomeDaBanda);

        bandaController.CadastrarBanda(novaBanda);

        ScreenSoundUI.EscreverFormatado($"A banda '{novaBanda.Nome}' foi registrada com sucesso!");
    }
}
