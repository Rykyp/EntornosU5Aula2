using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELeagueManager
{
    public abstract class Jugador
    {
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public int Nivel { get; set; }
    }
}
