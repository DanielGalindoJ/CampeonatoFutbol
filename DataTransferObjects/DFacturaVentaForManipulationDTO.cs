using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record DFacturaVentaForManipulationDTO
    {
        [Required(ErrorMessage = "ValorUnitario es un campo requerido.")]
        public float ValorUnitario { get; init; }

        [Required(ErrorMessage = "Cantidad es un campo requerido.")]
        public int Cantidad { get; init; }

        [Required(ErrorMessage = "IVA es un campo requerido.")]
        public float IVA { get; init; }

        [Required(ErrorMessage = "ValorDescuento es un campo requerido.")]
        public float ValorDescuento { get; init; }

        public Guid ProductoId { get; init; }

        public Guid FacturaVentaId { get; init; }
    }
}
