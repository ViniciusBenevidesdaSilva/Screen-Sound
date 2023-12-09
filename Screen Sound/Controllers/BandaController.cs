using Screen_Sound.Models;
using Screen_Sound.Services;
using Screen_Sound.UI;

namespace Screen_Sound.Controllers;

internal class BandaController
{
    private readonly BandaService bandaService;

    public BandaController()
    {
        bandaService = BandaService.Instance;
    }

    public void SolicitarCadastroDeBanda()
    {

        ScreenSoundUI.ExibirTituloDaOpcao("Registro de Banda");

        ScreenSoundUI.EscreverFormatado("Digite o nome da banda: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        Banda novaBanda = new(nomeDaBanda);

        bandaService.RegistrarBanda(novaBanda);

        ScreenSoundUI.EscreverFormatado($"A banda '{novaBanda.Nome}' foi registrada com sucesso!");
    }

    public void MostrarBandasRegistradas()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Listagem de Bandas Registradas");

        if (bandaService.QtdBandasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma banda cadastrada!");
        }
        else
        {
            foreach (Banda banda in bandaService.BandasRegistradas)
            {
                ScreenSoundUI.EscreverFormatado(banda.DescricaoResumida);
            }
        }
    }

    public void SolicitarAvaliacaoDeBanda()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Avaliar Banda Registrada");

        ScreenSoundUI.EscreverFormatado("Digite o nome da banda que deseja avaliar: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        if (bandaService.PesquisarBandaPorNome(nomeDaBanda) is not null)
        {
            ScreenSoundUI.EscreverFormatado($"Informe sua nota para a Banda {nomeDaBanda}: ", pularLinha: false);
            Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);

            bandaService.RegistrarAvaliacao(nomeDaBanda, avaliacao);

            ScreenSoundUI.EscreverFormatado($"A nota {avaliacao.Nota} foi registrada com sucesso para a Banda '{nomeDaBanda}'!");
        }
        else
        {
            ScreenSoundUI.EscreverFormatado($"A Banda '{nomeDaBanda}' não foi encontrada!");
        }
    }

    public void ExibirMediaBanda()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Exibir Avaliação Média Banda");

        ScreenSoundUI.EscreverFormatado("Digite o nome da Banda que deseja exibir a média: ", pularLinha: false);
        string nomeDaBanda = Console.ReadLine()!;

        Banda? bandaPesquisada = bandaService.PesquisarBandaPorNome(nomeDaBanda);

        if (bandaPesquisada is not null)
        {
            ScreenSoundUI.EscreverFormatado($"A média da Banda '{bandaPesquisada.Nome}' é de {bandaPesquisada.AvaliacaoMedia}!");
        }
        else
        {
            Console.WriteLine($"\tA Banda '{nomeDaBanda}' não foi encontrada!");
        }
    }

    internal void MostrarListagemGeral()
    {
        ScreenSoundUI.ExibirTituloDaOpcao("Listagem Geral");

        if (bandaService.QtdBandasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma banda cadastrada!");
        }
        else
        {
            foreach (Banda banda in bandaService.BandasRegistradas)
            {
                banda.ExibirAlbums();
                Console.WriteLine();
            }
        }
    }
}