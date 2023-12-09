using Screen_Sound.Models;

namespace Screen_Sound.Services;

internal class AlbumService
{
    public List<Album> AlbunsRegistrados { get; } = new List<Album>();

    public int QtdAlbunsRegistradas => AlbunsRegistrados.Count;

    private AlbumService() { }


    private static readonly Lazy<AlbumService> instance = new(() => new AlbumService());
    public static AlbumService Instance => instance.Value;


    public void RegistrarAlbum(Album novoAlbum)
    {
        AlbunsRegistrados.Add(novoAlbum);
    }

    public Album? PesquisarAlbumPorNome(string nomeDoAlbum)
    {
        return AlbunsRegistrados.FirstOrDefault(a => a.Nome.ToUpper() == nomeDoAlbum.ToUpper());
    }
}