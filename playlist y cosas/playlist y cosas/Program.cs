using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playlist_y_cosas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apartado de Artistas
            Artista CuartetoDeNos = new Artista();
            CuartetoDeNos.nombreArtista = "Cuarteto de Nos";
            CuartetoDeNos.cantidadDeAlbumes = 17;
            CuartetoDeNos.edadBanda = 43;
            CuartetoDeNos.integrantes = 6;

            Artista TwentyOnePilots = new Artista();
            TwentyOnePilots.nombreArtista = "Twenty One Pilots";
            TwentyOnePilots.cantidadDeAlbumes = 18;
            TwentyOnePilots.edadBanda = 14;
            TwentyOnePilots.integrantes = 2;

            Artista Gorillaz = new Artista();
            Gorillaz.nombreArtista = "Gorillaz";
            Gorillaz.cantidadDeAlbumes = 21;
            Gorillaz.edadBanda = 25;
            Gorillaz.integrantes = 4;

            Artista TheStrokes = new Artista();
            TheStrokes.nombreArtista = "The Strokes";
            TheStrokes.cantidadDeAlbumes = 10;
            TheStrokes.edadBanda = 25;
            TheStrokes.integrantes = 5;

            Artista AJR = new Artista();
            AJR.nombreArtista = "AJR";
            AJR.cantidadDeAlbumes = 8;
            AJR.edadBanda = 17;
           AJR.integrantes = 3;

            //Apartado de Albumes

            Album Blurryface = new Album();
            Blurryface.nombreAlbum = "Blurryface";
            Blurryface.numeroDeCanciones = 14;
            Blurryface.ArtistaAlbum = TwentyOnePilots;
            Blurryface.generoAlbum = "Pop Rock";

            Album ApocalipsisZombi = new Album();
            ApocalipsisZombi.nombreAlbum = "Apocalipsis Zombi";
            ApocalipsisZombi.numeroDeCanciones = 10;
            ApocalipsisZombi.ArtistaAlbum = CuartetoDeNos;
            ApocalipsisZombi.generoAlbum = "Rock en español";

            Album PlasticBeach = new Album();
            PlasticBeach.nombreAlbum = "Plastic Beach";
            PlasticBeach.numeroDeCanciones = 16;
            PlasticBeach.ArtistaAlbum = Gorillaz;
            PlasticBeach.generoAlbum = "Pop Rock";

            Album TNA = new Album();
            TNA.nombreAlbum = "The New Abdominal";
            TNA.numeroDeCanciones = 10;
            TNA.ArtistaAlbum = TheStrokes;
            TNA.generoAlbum = "Rock indie";

            Album OkOrch = new Album();
            OkOrch.nombreAlbum = "OK Orchesta";
            OkOrch.numeroDeCanciones = 13;
            OkOrch.ArtistaAlbum = AJR;
            OkOrch.generoAlbum = "Folk";

            //Apartado de Canciones

            Cancion MessegeMan = new Cancion();
            MessegeMan.nombreCancion = "MessegeMan";
            MessegeMan.duracionMinutos = 4;
            MessegeMan.ArtistaCancion = TwentyOnePilots;
            MessegeMan.AlbumCancion = Blurryface;

            Cancion Invisible = new Cancion();
            Invisible.nombreCancion = "Invisible";
            Invisible.duracionMinutos = 3;
            Invisible.ArtistaCancion = CuartetoDeNos;
            Invisible.AlbumCancion = ApocalipsisZombi;

            Cancion TheAdultsAreTalking = new Cancion();
            TheAdultsAreTalking.nombreCancion = "The Adults Are Talking";
            TheAdultsAreTalking.duracionMinutos = 5;
            TheAdultsAreTalking.ArtistaCancion = TheStrokes;
            TheAdultsAreTalking.AlbumCancion = TNA;

            Cancion Broken = new Cancion();
            Broken.nombreCancion = "Broken";
            Broken.duracionMinutos = 3;
            Broken.ArtistaCancion = Gorillaz;
            Broken.AlbumCancion = PlasticBeach;

            Cancion Bang = new Cancion();
            Bang.nombreCancion = "Bang!";
            Bang.duracionMinutos = 3;
            Bang.ArtistaCancion = AJR;
            Bang.AlbumCancion = OkOrch;
        }
    }
}
