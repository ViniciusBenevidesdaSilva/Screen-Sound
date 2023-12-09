using Screen_Sound.Controllers;
using Screen_Sound.Models;

namespace Screen_Sound.UI.Menus;

internal class MenuAvaliarBanda : MenuBase
{
    readonly BandaController bandaController = new();

    public override void Exibir()
    {
        ExibirTituloDoMenu("Avaliar Banda Registrada");

        if (bandaController.QtdBandasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma banda registrada!");
            return;
        }

        ScreenSoundUI.EscreverFormatado("Digite o nome da banda que deseja avaliar: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        ScreenSoundUI.EscreverFormatado($"Informe sua nota para a Banda {nomeDaBanda}: ", pularLinha: false);
        Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);

        if (bandaController.RegistrarAvaliacao(nomeDaBanda, avaliacao))
        {
            ScreenSoundUI.EscreverFormatado($"A nota {avaliacao.Nota} foi registrada com sucesso para a Banda '{nomeDaBanda}'!");
        }
        else
        {
            ScreenSoundUI.EscreverFormatado($"A Banda '{nomeDaBanda}' não foi encontrada!");
        }
    }
}