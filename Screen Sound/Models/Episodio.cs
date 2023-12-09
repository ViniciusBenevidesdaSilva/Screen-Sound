using Screen_Sound.UI;

namespace Screen_Sound.Models;

internal class Episodio
{
    private readonly List<string> convidados = new();

    public int Ordem { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string DescricaoResumida => $"{Ordem}. Título: {Titulo}, Duração: {Duracao} min";

    public Episodio(string titulo, int duracao)
    {
        this.Titulo = titulo;
        this.Duracao = duracao;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

    public void ExibirDetalhes()
    {
        ScreenSoundUI.EscreverFormatado($"\t\tOrdem: {Ordem}.");
        ScreenSoundUI.EscreverFormatado($"\t\tTitulo: {Titulo}.");
        ScreenSoundUI.EscreverFormatado($"\t\tDuracao: {Duracao} min.");
        ScreenSoundUI.EscreverFormatado($"\t\tConvidados: {string.Join(", ", convidados)}.");
    }
}