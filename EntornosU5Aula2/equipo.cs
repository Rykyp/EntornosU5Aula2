using System;
using System.Collections.Generic;

namespace ELeagueManager
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public DateTime FechaFundacion { get; set; }
        private List<Jugador> _jugadores;
        private PerfilEstadisticas _estadisticas;

        public Equipo(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaFundacion = fecha;
            _jugadores = new List<Jugador>();

            // COMPOSICION El equipo crea su propio perfíl
            _estadisticas = new PerfilEstadisticas();
        }

        // AGREGACION: Los jugadores se pasan al equipo 
        public void FicharJugador(Jugador j)
        {
            _jugadores.Add(j);
        }
    }
}