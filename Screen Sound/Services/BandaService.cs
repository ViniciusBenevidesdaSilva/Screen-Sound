using Screen_Sound.Models;

namespace Screen_Sound.Services;

internal class BandaService
{
    public List<Banda> BandasRegistradas { get; } = new();

    public int QtdBandasRegistradas => BandasRegistradas.Count;

    private BandaService() { }


    private static readonly Lazy<BandaService> instance = new(() => new BandaService());
    public static BandaService Instance => instance.Value;


    public void RegistrarBanda(Banda banda)
    {
        BandasRegistradas.Add(banda);
    }

    public Banda? PesquisarBandaPorNome(string nomeDaBanda)
    {
        return BandasRegistradas.FirstOrDefault(b => b.Nome.ToUpper() == nomeDaBanda.ToUpper());
    }

    public void RegistrarAvaliacao(string nomeDaBanda, Avaliacao avalicao)
    {
        PesquisarBandaPorNome(nomeDaBanda)?.AdicionarAvaliacao(avalicao);
    }
}