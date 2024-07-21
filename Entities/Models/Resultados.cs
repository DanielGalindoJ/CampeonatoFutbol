using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Resultados
    {

        public int Id { get; set; }
        public int EquipoLocalId { get; set; }
        public Equipo EquipoLocal { get; set; }
        public int EquipoVisitanteId { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime Fecha { get; set; }
        public int EstadioId { get; set; }
        public Estadios Estadio { get; set; }



    }
}
