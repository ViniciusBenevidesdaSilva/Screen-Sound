namespace Screen_Sound.UI.Menus;

public abstract class MenuBase
{
    internal static void ExibirTituloDoMenu(string titulo)
    {
        string simbolos = string.Empty.PadLeft(titulo.Length, '*');

        Console.Clear();

        ScreenSoundUI.EscreverFormatado($"{simbolos}");
        ScreenSoundUI.EscreverFormatado($"{titulo}");
        ScreenSoundUI.EscreverFormatado($"{simbolos}\n");
    }

    public abstract void Exibir();
}