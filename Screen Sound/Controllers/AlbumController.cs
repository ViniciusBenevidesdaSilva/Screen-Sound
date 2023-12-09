using Screen_Sound.Models;
using Screen_Sound.Services;

namespace Screen_Sound.Controllers;

internal class AlbumController
{
    private readonly AlbumService albumService;

    public int QtdAlbunsRegistradas => albumService.QtdAlbunsRegistradas;

    public AlbumController()
    {
        albumService = AlbumService.Instance;
    }

    public Album? PesquisarAlbumPorNome(string nomeDoAlbum) => albumService.PesquisarAlbumPorNome(nomeDoAlbum);

    public void CadastrarAlbum(Album novoAlbum)
    {
        albumService.RegistrarAlbum(novoAlbum);
        novoAlbum.Banda.AdicionarAlbum(novoAlbum);
    }
}