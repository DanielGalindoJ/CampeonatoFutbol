using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record ClienteForCreationDTO
  (
        string Documento,
        string Nombre,
        string Apellido,
        string Correo,
        long Contacto,
        string Direccion,
        IEnumerable<FacturaVentaDTO>? FacturaClientes);
}