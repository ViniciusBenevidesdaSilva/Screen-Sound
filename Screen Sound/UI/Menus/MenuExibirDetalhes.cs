using Screen_Sound.Controllers;
using Screen_Sound.Models;

namespace Screen_Sound.UI.Menus;

internal class MenuExibirDetalhes : MenuBase
{
    readonly BandaController bandaController = new();

    public override void Exibir()
    {
        ExibirTituloDoMenu("Listagem Geral");

        if (bandaController.QtdBandasRegistradas == 0)
        {
            ScreenSoundUI.EscreverFormatado("Nenhuma banda registrada!");
        }
        else
        {
            ExibirDetalhesDasBandas();
        }
    }

    private void ExibirDetalhesDasBandas()
    {
        foreach (Banda banda in bandaController.BandasRegistradas)
        {
            Console.WriteLine();

            ScreenSoundUI.EscreverFormatado(banda.DescricaoResumida);

            if (banda.QtdAlbuns == 0)
            {
                ScreenSoundUI.EscreverFormatado("  Essa banda não possuí nenhum álbum cadastrado");
            }
            else
            {
                ExibirDetalhesDosAlbuns(banda);
            }
        }
    }


    private void ExibirDetalhesDosAlbuns(Banda banda)
    {
        foreach (Album album in banda.Albuns)
        {
            ScreenSoundUI.EscreverFormatado($"  {album.DescricaoResumida}");

            if (album.QtdMusicas == 0)
            {
                ScreenSoundUI.EscreverFormatado("    Esse álbum não possuí nenhuma música cadastrada");
            }
            else
            {
                ExibirDetalhesDasMusicas(album);
            }
        }
    }

    private void ExibirDetalhesDasMusicas(Album album)
    {
        foreach (Musica musica in album.Musicas)
        {
            ScreenSoundUI.EscreverFormatado($"    {musica.DescricaoResumida}");
        }
    }
}
