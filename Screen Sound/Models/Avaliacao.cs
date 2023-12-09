namespace Screen_Sound.Models;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public static Avaliacao Parse(string texto)
    {
        return new Avaliacao(int.Parse(texto));
    }
}
