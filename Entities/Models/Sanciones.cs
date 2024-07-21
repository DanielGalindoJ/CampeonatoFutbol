using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Sanciones

    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? JugadorId { get; set; }
        public Jugadores Jugador { get; set; }
        public int? EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}
