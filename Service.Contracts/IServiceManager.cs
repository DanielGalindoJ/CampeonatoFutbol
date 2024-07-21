using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Service.Contracts.Users;

namespace Service.Contracts
{
    public interface IServiceManager
    {


        IAuthenticationService AuthenticationService { get; }
    }
}
