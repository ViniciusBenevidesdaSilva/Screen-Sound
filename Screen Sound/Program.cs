// Screen Sound
string mensagemDeBoasVindas = "\tBoas vindas ao Screen Sound!";

void ExibirMensagemDeBoasVindas()
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

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n\t[1] para registrar uma banda");
    Console.WriteLine("\t[2] para mostrar todas as bandas");
    Console.WriteLine("\t[3] para avaliar uma banda");
    Console.WriteLine("\t[4] para exibir a média de uma banda");
    Console.WriteLine("\t[0] para sair");

    Console.Write("\nDigite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}


ExibirMensagemDeBoasVindas();

ExibirOpcoesDoMenu();

