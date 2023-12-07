class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\tNome: {nome}");
        Console.WriteLine($"\tArtista: {artista}");
        Console.WriteLine($"\tDuração: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("\tDisponível no plano");
        }
        else
        {
            Console.WriteLine("\tAdiquira o plano Plus+");
        }
    }
}