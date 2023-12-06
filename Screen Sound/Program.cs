// Screen Sound
string mensagemDeBoasVindas = "\tBoas vindas ao Screen Sound!";
List<string> listaDasBandas = new();


void ExibirLogo()
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
    ExibirLogo();

    Console.WriteLine("\n\t[1] para registrar uma banda");
    Console.WriteLine("\t[2] para mostrar todas as bandas");
    Console.WriteLine("\t[3] para avaliar uma banda");
    Console.WriteLine("\t[4] para exibir a média de uma banda");
    Console.WriteLine("\t[0] para sair");

    Console.Write("\nDigite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda();
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

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("\tRegistro de bandas");

    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);

    Console.Clear();
    ExibirOpcoesDoMenu();
}


ExibirOpcoesDoMenu();
