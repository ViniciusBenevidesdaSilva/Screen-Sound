﻿// Screen Sound
string mensagemDeBoasVindas = "\tBoas vindas ao Screen Sound!";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

List<Musica> musicasRegistradas = new List<Musica>();

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
    Console.WriteLine("\t[5] para registrar uma música");
    Console.WriteLine("\t[6] para mostrar todas as músicas");
    Console.WriteLine("\t[0] para sair");

    Console.Write("\n\tDigite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBandaRegistrada();
            break;
        case 4: ExibirMediaBanda();
            break;
        case 5: RegistrarMusica();
            break;
        case 6: MostrarMusicasRegistradas();
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

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"\tA banda '{nomeDaBanda}' já está registrada!");
    }
    else
    {
        bandasRegistradas.Add(nomeDaBanda, new List<int>());

        Console.WriteLine($"\tA banda '{nomeDaBanda}' foi registrada com sucesso!");
    }

    Console.Write("\n\tDigite uma tecla para voltar ao menu ");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    ExibirTituloDaOpcao("Listagem de Bandas Registradas");

    if(bandasRegistradas.Count == 0)
    {
        Console.WriteLine("\tNenhuma banda cadastrada!");
    }
    else
    {
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"\tBanda: {banda}");
        }
    }

    Console.Write("\n\tDigite uma tecla para voltar ao menu ");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void AvaliarBandaRegistrada()
{
    ExibirTituloDaOpcao("Avaliar Banda Registrada");

    Console.Write("\tDigite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\tInforme sua nota para a Banda {nomeDaBanda}: ");
        int notaInformada = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(notaInformada);

        Console.WriteLine($"\n\tA nota {notaInformada} foi registrada com sucesso para a Banda '{nomeDaBanda}'!");
    }
    else
    {
        Console.WriteLine($"\tA Banda '{nomeDaBanda}' não foi encontrada!");
    }

    Console.Write("\n\tDigite uma tecla para voltar ao menu ");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void ExibirMediaBanda()
{
    ExibirTituloDaOpcao("Exibir Avaliação Média Banda");

    Console.Write("\tDigite o nome da Banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        if(bandasRegistradas[nomeDaBanda].Count == 0)
        {
            Console.WriteLine($"\tNenhuma avaliação cadastrada para a Banda '{nomeDaBanda}'.");
        }
        else
        {
            double avaliacaoMedia = bandasRegistradas[nomeDaBanda].Average();
            Console.WriteLine($"\tA média da Banda '{nomeDaBanda}' é de {avaliacaoMedia}!");
        }
    }
    else
    {
        Console.WriteLine($"\tA Banda '{nomeDaBanda}' não foi encontrada!");
    }

    Console.Write("\n\tDigite uma tecla para voltar ao menu ");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void RegistrarMusica()
{
    ExibirTituloDaOpcao("Registro de Música");

    Musica novaMusica = new Musica();
    
    Console.Write("\tDigite o nome da música: ");
    novaMusica.nome = Console.ReadLine()!;
    
    Console.Write("\tDigite o artista da música: ");
    novaMusica.artista = Console.ReadLine()!; 
    
    Console.Write("\tDigite a duração da música: ");
    novaMusica.duracao = int.Parse(Console.ReadLine()!); 
    
    Console.Write("\tDigite [S] se a música estiver disponível ou [N] caso contrário: ");
    novaMusica.disponivel = Console.ReadLine()!.ToUpper()[0] == 'S';


    musicasRegistradas.Add(novaMusica);
    
    Console.WriteLine($"\n\tA música '{novaMusica.nome}' foi registrada com sucesso!");

    Console.Write("\n\tDigite uma tecla para voltar ao menu ");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void MostrarMusicasRegistradas()
{
    ExibirTituloDaOpcao("Listagem de Músicas Registradas");

    if (musicasRegistradas.Count == 0)
    {
        Console.WriteLine("\tNenhuma música cadastrada!");
    }
    else
    {
        foreach (Musica musica in musicasRegistradas)
        {
            musica.ExibirFichaTecnica();
            Console.WriteLine();

        }
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


try
{
    ExibirOpcoesDoMenu();
}
catch(Exception ex)
{
    Console.WriteLine($"\tErro: {ex.Message}");
}
