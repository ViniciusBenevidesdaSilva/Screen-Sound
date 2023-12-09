using Screen_Sound.Controllers;
using Screen_Sound.UI;

namespace Screen_Sound;

internal class Program
{
    static readonly BandaController bandaController = new();
    static readonly AlbumController albumController = new();
    static readonly MusicaController musicaController = new();

    private static void Main(string[] args)
    {
        try
        {
            IniciarPrograma();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\tErro: {ex.Message}");
        }
    }


    private static void IniciarPrograma()
    {
        int opcaoEscolhida = -1;

        while (true)
        {
            ScreenSoundUI.ExibirMenu();
            try
            {
                opcaoEscolhida = int.Parse(Console.ReadLine()!);

                switch (opcaoEscolhida)
                {
                    case 1:
                        bandaController.SolicitarCadastroDeBanda();
                        break;
                    case 2:
                        bandaController.MostrarBandasRegistradas();
                        break;
                    case 3:
                        bandaController.SolicitarAvaliacaoDeBanda();
                        break;
                    case 4:
                        bandaController.ExibirMediaBanda();
                        break;
                    case 5:
                        albumController.SolicitarCadastroDeAlbum();
                        break;
                    case 6:
                        albumController.MostrarAlbunsRegistrados();
                        break;
                    case 7:
                        musicaController.SolicitarCadastroDeMusica();
                        break;
                    case 8:
                        musicaController.MostrarMusicasRegistradas();
                        break;
                    case 9:
                        bandaController.MostrarListagemGeral();
                        break;
                    case 0:
                        ScreenSoundUI.EscreverFormatado("Tchau Tchau :)");
                        break;
                    default:
                        ScreenSoundUI.EscreverFormatado("Opção Inválida!");
                        break;
                }

                if (opcaoEscolhida == 0)
                    break;
            }
            catch
            {
                ScreenSoundUI.EscreverFormatado("Opção Inválida!");
            }

            ScreenSoundUI.EscreverFormatado("\n\tDigite uma tecla para voltar ao menu ", pularLinha: false);
            Console.ReadKey();
        }
    }
}