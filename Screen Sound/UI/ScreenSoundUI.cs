namespace Screen_Sound.UI;

internal class ScreenSoundUI
{
    private static readonly string mensagemDeBoasVindas = "\tBoas vindas ao Screen Sound!";


    public static void ExibirLogo()
    {
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
        Console.WriteLine(mensagemDeBoasVindas);
    }

    public static void ExibirMenu()
    {
        Console.Clear();
        ExibirLogo();

        Console.WriteLine();
        EscreverFormatado("[1] para registrar uma BANDA");
        EscreverFormatado("[2] para registrar um ÁLBUM");
        EscreverFormatado("[3] para registrar uma MÚSICA");
        EscreverFormatado("[4] para avaliar uma BANDA");
        EscreverFormatado("[5] para exibir todos os detalhes");
        EscreverFormatado("[0] para sair");

        Console.WriteLine();
        EscreverFormatado("Digite a sua opção: ", pularLinha: false);
    }

    public static void EscreverFormatado(string texto, bool pularLinha = true)
    {
        if (pularLinha)
        {
            Console.WriteLine($"\t{texto}");
        }
        else
        {
            Console.Write($"\t{texto}");
        }
    }
}