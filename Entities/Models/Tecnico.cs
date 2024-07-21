using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cedula { get; set; }
        public int EquipoId { get; set; }
        public Equipo Equipo { get; set; }
    }
}
