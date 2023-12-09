using Screen_Sound.UI;
using Screen_Sound.UI.Menus;

namespace Screen_Sound;

internal class Program
{
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
        Dictionary<int, MenuBase> opcoes = new()
        {
            { 0, new MenuSair() },
            { 1, new MenuCadastrarBanda() },
            { 2, new MenuCadastrarAlbum() },
            { 3, new MenuCadastrarMusica() },
            { 4, new MenuAvaliarBanda() },
            { 5, new MenuExibirDetalhes() },
        };

        while (true)
        {
            ScreenSoundUI.ExibirMenu();
            try
            {
                int opcaoEscolhida = int.Parse(Console.ReadLine()!);
                
                if(!opcoes.ContainsKey(opcaoEscolhida))
                {
                    ScreenSoundUI.EscreverFormatado("Opção Inválida!");
                }
                else
                {
                    MenuBase menuASerExibido = opcoes[opcaoEscolhida];
                    
                    menuASerExibido.Exibir();

                    if (opcaoEscolhida == 0)
                        break;
                }
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