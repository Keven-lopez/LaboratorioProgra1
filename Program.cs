using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio.ClaseHija;
using LaboratorioProgra1.Laboratorio.ClasePadre;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 5;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

JuegoBattleRoyale Fortnite = new JuegoBattleRoyale();
Fortnite.Titulo = "fortnite";
Fortnite.Desarrolladora = "Epic Games";
Fortnite.Calificacion = 9;
Fortnite.AnioLanzamiento = 2017;
Fortnite.jugadores_max = 100;
Fortnite.punto_de_vista = "Tercera Persona";
Fortnite.consolas = "Varias";
Console.WriteLine(Fortnite.MostrarDetalleBR());

Console.WriteLine("");
JuegoFPS COD = new JuegoFPS();
COD.Titulo = "Call of Duty: Modern Warfare 3";
COD.Desarrolladora = "Infinity Ward";
COD.Calificacion = 10;
COD.AnioLanzamiento = 2023;
COD.Modos_Juego = "Un jugador, multijugador, o cooperativo";
COD.Realista_Subrealista = "Subrealista";
COD.Tiempo_Partida = "Corta";
Console.WriteLine(COD.MostrarDetalleFPS());

Console.WriteLine("");
JuegoPlataformas Mario = new JuegoPlataformas();
Mario.Titulo = "Mario Bros Wonder";
Mario.Desarrolladora = "Nintendo";
Mario.Calificacion = 9;
Mario.AnioLanzamiento = 2023;
Mario.Formato = "Digital o cartucho";
Mario.Dificultad = "Facil";
Mario.Tiempo_Completar = "18-22 horas";
Console.WriteLine(Mario.MostrarDetallesPlat());

Laboratorio();
//ideoJuego.listaDeJuegos();



