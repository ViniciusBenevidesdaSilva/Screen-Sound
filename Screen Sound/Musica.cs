class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}"; 


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\tNome: {Nome}");
        Console.WriteLine($"\tArtista: {Artista}");
        Console.WriteLine($"\tDuração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("\tDisponível no plano");
        }
        else
        {
            Console.WriteLine("\tAdiquira o plano Plus+");
        }
    }
}