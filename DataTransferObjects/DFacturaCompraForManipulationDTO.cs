using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record DFacturaCompraForManipulationDTO
    {
        [Required(ErrorMessage = "Este es un campo requerido")]
        public float ValorUnitario { get; init; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        public int Cantidad { get; init; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        public float IVA { get; init; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        public float ValorDescuento { get; init; }

        public Guid FacturaCompraId { get; init; }

        public Guid ProductoId { get; init; }
    }
}
