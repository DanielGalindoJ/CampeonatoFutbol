using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record FacturaCompraForManipulationDTO
    {
        [Required(ErrorMessage = "NFactura es un campo requerido.")]
        public int NFactura { get; init; }

        [Required(ErrorMessage = "FechaGeneracion es un campo requerido.")]
        public DateTime? FechaGeneracion { get; init; }

        [Required(ErrorMessage = "FechaExpedicion es un campo requerido.")]
        public DateTime? FechaExpedicion { get; init; }

        [Required(ErrorMessage = "FechaVencimiento es un campo requerido.")]
        public DateTime? FechaVencimiento { get; init; }

        [Required(ErrorMessage = "TotalBruto es un campo requerido.")]
        public float TotalBruto { get; init; }

        [Required(ErrorMessage = "TotalIVA es un campo requerido.")]
        public float TotalIVA { get; init; }

        [Required(ErrorMessage = "TotalRetFuente es un campo requerido.")]
        public float TotalRetFuente { get; init; }

        [Required(ErrorMessage = "TotalPago es un campo requerido.")]
        public float TotalPago { get; init; }
    }
}
