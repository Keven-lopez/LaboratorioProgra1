using LaboratorioProgra1.Laboratorio.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClaseHija
{
    internal class JuegoPlataformas : VideoJuego
    {
        public string Formato {  get; set; }
        public string Dificultad {  get; set; }
        public string Tiempo_Completar { get; set; }
        public string MostrarDetallesPlat()
        {
            return MostrarInformacion() + $"Formato: {Formato}\nDificultad: {Dificultad}\nTiempo_Completar: {Tiempo_Completar}";
        }
    }
}
