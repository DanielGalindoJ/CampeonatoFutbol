using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures.Parameters
{
    public class CargoParameters : RequestParameters
    {
        public uint Estado {  get; set; }
        public bool EstadoValido => (Estado >= 0 && Estado <= 1);

        public string? SearchTerm { get; set; }
    }
}
