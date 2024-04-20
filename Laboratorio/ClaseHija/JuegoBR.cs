using LaboratorioProgra1.Laboratorio.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClaseHija
{
    internal class JuegoBattleRoyale : VideoJuego
    {
        public int jugadores_max { get; set; }
        public string punto_de_vista { get; set; }
        public string consolas { get; set; }

        public string MostrarDetalleBR()
        {
            return MostrarInformacion() + $"Jugadores: {jugadores_max}\nPunto de Vista: {punto_de_vista}\nConsolas: {consolas}";
        }
    }
}