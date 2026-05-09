using System;

namespace ELeagueManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo team = new Equipo("E-Masters", DateTime.Now);
            Profesional pro = new Profesional { Alias = "JugadorProfesional", Sueldo = 3000 };

            GestorFichajes gestor = new GestorFichajes();
            gestor.TramitarAlta(team, pro);

            pro.RealizarDeclaraciones();
            Console.WriteLine("Sistema eleague Manager funcionando correctamente .");
        }
    }
}