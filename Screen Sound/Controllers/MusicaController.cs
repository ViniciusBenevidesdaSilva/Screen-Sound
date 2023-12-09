using Screen_Sound.Models;
using Screen_Sound.Services;

namespace Screen_Sound.Controllers;

internal class MusicaController
{
    private readonly MusicaService musicaService;

    public MusicaController()
    {
        musicaService = MusicaService.Instance;
    }

    public void CadastrarMusica(Musica novaMusica)
    {
        musicaService.RegistrarMusica(novaMusica);
        novaMusica.Album.AdicionarMusica(novaMusica);
    }
}