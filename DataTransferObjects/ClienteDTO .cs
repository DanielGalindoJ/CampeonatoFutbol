using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record ClienteDTO
    {
        public Guid IdCliente { get; init; }
        public string? Documento { get; init; }
        public string? Nombre { get; init; }
        public string? Apellido { get; init; }
        public string? Correo { get; init; }
        public long Contacto { get; init; }
        public string? Direccion { get; init; }


    }
}


    