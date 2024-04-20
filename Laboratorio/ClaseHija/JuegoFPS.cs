using LaboratorioProgra1.Laboratorio.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClaseHija
{
    internal class JuegoFPS : VideoJuego
    {
        public string Modos_Juego { get; set; }
        public string Realista_Subrealista { get; set; }
        public string Tiempo_Partida { get; set; }
        public string MostrarDetalleFPS() 
        { 
            return MostrarInformacion() + $"Modos de Jugar: {Modos_Juego}\nEs Realista o Subrealista: {Realista_Subrealista}\nTiempo por Partida: {Tiempo_Partida}";
        }
    }
}
