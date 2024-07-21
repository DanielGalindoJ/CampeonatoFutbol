﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record MetodoPagoForCreationDTO(
        DateTime FechaTransaccion, 
        int Monto, 
        string NombrePlataforma,
        Guid FacturaId
        );
}
