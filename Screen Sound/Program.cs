﻿// Screen Sound
string mensagemDeBoasVindas = "\tBoas vindas ao Screen Sound!";
List<string> listaDasBandas = new() { "U2", "The Beatles", "Calypso"};


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
    Console.Clear();
    ExibirLogo();

    Console.WriteLine("\n\t[1] para registrar uma banda");
    Console.WriteLine("\t[2] para mostrar todas as bandas");
    Console.WriteLine("\t[3] para avaliar uma banda");
    Console.WriteLine("\t[4] para exibir a média de uma banda");
    Console.WriteLine("\t[0] para sair");

    Console.Write("\n\tDigite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0: Console.WriteLine("\tTchau Tchau :)");
            break;
        default: Console.WriteLine("\tOpção Inválida!");
            break;
    }
}

void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registro de Banda");

    Console.Write("\tDigite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);

    Console.WriteLine($"\tA banda '{nomeDaBanda}' foi registrada com sucesso!");

    Console.Write("\t.");
    Thread.Sleep(500);
    Console.Write("."); 
    Thread.Sleep(500);
    Console.Write("."); 
    Thread.Sleep(500);

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Listagem de Bandas Registradas");

    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine($"\tBanda: {banda}");
    }

    Console.Write("\n\tDigite uma tecla para voltar ao menu ");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    string asteriscos = string.Empty.PadLeft(titulo.Length, '*');
    
    Console.Clear();

    Console.WriteLine($"\t{asteriscos}");
    Console.WriteLine($"\t{titulo}");
    Console.WriteLine($"\t{asteriscos}\n");
}

ExibirOpcoesDoMenu();
