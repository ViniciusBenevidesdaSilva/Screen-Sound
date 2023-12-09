using Screen_Sound.Models;

namespace Screen_Sound.Services;

internal class MusicaService
{
    public List<Musica> MusicasRegistradas { get; } = new List<Musica>();

    public int QtdMusicasRegistradas => MusicasRegistradas.Count;

    private MusicaService() { }


    private static readonly Lazy<MusicaService> instance = new(() => new MusicaService());
    public static MusicaService Instance => instance.Value;


    public void RegistrarMusica(Musica novaMusica)
    {
        MusicasRegistradas.Add(novaMusica);
    }
}