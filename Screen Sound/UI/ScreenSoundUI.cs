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
        EscreverFormatado("[2] para mostrar todas as BANDAS");
        EscreverFormatado("[3] para avaliar uma BANDA");
        EscreverFormatado("[4] para exibir a média de uma BANDA");
        EscreverFormatado("[5] para registrar um ÁLBUM");
        EscreverFormatado("[6] para mostrar todos os ÁLBUNS");
        EscreverFormatado("[7] para registrar uma MÚSICA");
        EscreverFormatado("[8] para mostrar todas as MÚSICAS");
        EscreverFormatado("[9] para mostrar todas as informações registradas");
        EscreverFormatado("[0] para sair");

        Console.WriteLine();
        EscreverFormatado("Digite a sua opção: ", pularLinha: false);
    }

    public static void ExibirTituloDaOpcao(string titulo)
    {
        string asteriscos = string.Empty.PadLeft(titulo.Length, '*');

        Console.Clear();

        Console.WriteLine($"\t{asteriscos}");
        Console.WriteLine($"\t{titulo}");
        Console.WriteLine($"\t{asteriscos}\n");
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