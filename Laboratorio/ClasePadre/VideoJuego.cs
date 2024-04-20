using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.ClasePadre
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;
        private bool detenida;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                //  La calificación debe estar entre 0 y 10
                if (value > 0 || value < 10)
                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }

            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                if (value < 1972 || value > 2024)
                {
                    Console.WriteLine("Fecha fuera del rango");
                }
                else
                {
                    anioLanzamiento = value;
                }
            }
        }

        public string MostrarInformacion()
        {
            return $"Título: {Titulo}\nDesarrolladora: {Desarrolladora}\nCalificación: {Calificacion}\nAño de Lanzamiento: {AnioLanzamiento}\n";
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            detenida = false;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            jugando = false;
            detenida = true;
            Console.WriteLine("Partida detenida.");
        }

        public void TerminarJuego()
        {
            // Error lógico
            if (jugando==true)
            {
                Console.WriteLine("Juego terminado.");
            }
            else if (detenida == true)
            {
                Console.WriteLine("El juego se detuvo");
            }
            else if (jugando==false) 
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

    }
}
