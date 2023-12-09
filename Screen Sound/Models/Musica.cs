namespace Screen_Sound.Models;

internal class Musica
{
    public string Nome { get; set; }
    public Album Album { get; set; }
    public Genero Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"Música: {Nome}, Gênero: {Genero?.Nome}, Duração: {Duracao} s, " + (Disponivel ? "Disponível no plano" : "Adiquira o plano Plus+");


    public Musica(string nome, Album album)
    {
        this.Nome = nome;
        this.Album = album;
    }
}