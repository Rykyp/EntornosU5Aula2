using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELeagueManager
{
    public class GestorFichajes
    {
        public void TramitarAlta(Equipo equipo, Jugador jugador)
        {
            equipo.FicharJugador(jugador);
        }
    }
}