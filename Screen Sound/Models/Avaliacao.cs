namespace Screen_Sound.Models;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        Nota = Math.Clamp(nota, 0, 10);
    }

    public static Avaliacao Parse(string texto)
    {
        return new Avaliacao(int.Parse(texto));
    }
}
