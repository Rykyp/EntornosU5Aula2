using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELeagueManager
{
    public class Profesional : Jugador, IEntrevistable
    {
        public double Sueldo { get; set; }
        public string Patrocinador { get; set; }

        public void RealizarDeclaraciones()
        {
            System.Console.WriteLine($"{Alias} dice: 'Daremos todo en el próximo torneo'.");
        }
    }

    public class Amateur : Jugador
    {
        public string CentroEstudios { get; set; }
    }
}