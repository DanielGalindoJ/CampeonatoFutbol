﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record MetodoPagoDTO
    {
        public Guid IdMetodoPago { get; init; }
        public DateTime FechaTransaccion { get; init; }
        public int Monto { get; init; }
        public string? NombrePlataforma { get; init; }
        public Guid FacturaId { get; init; }
    }
}
