using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Jugadores
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NPosition { get; set; }
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}
