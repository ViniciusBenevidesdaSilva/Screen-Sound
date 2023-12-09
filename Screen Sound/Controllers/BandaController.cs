using Screen_Sound.Models;
using Screen_Sound.Services;

namespace Screen_Sound.Controllers;

internal class BandaController
{
    private readonly BandaService bandaService;
    
    public int QtdBandasRegistradas => bandaService.QtdBandasRegistradas;
    public List<Banda> BandasRegistradas => bandaService.BandasRegistradas;

    public BandaController()
    {
        bandaService = BandaService.Instance;
    }


    public Banda? PesquisarBandaPorNome(string nomeDaBanda) => bandaService.PesquisarBandaPorNome(nomeDaBanda);

    internal void CadastrarBanda(Banda novaBanda)
    {
        bandaService.RegistrarBanda(novaBanda);
    }

    public bool RegistrarAvaliacao(string nomeDaBanda, Avaliacao avaliacao)
    {
        if (bandaService.PesquisarBandaPorNome(nomeDaBanda) is null)
            return false;
            
        bandaService.RegistrarAvaliacao(nomeDaBanda, avaliacao);
        return true;
    }
}