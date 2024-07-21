using AutoMapper;
using Contracts;
using Entities.ConfigurationModels;
using Entities.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Service.Contracts.Users;
using Service.Contracts;
using Service.Users;
using System;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
       
        private readonly IAuthenticationService _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IOptions<JwtConfiguration> configuration)
        {
          
            _authenticationService = new AuthenticationService(logger, mapper, userManager, configuration);
        }

        /* Productos */

       
        public IAuthenticationService AuthenticationService => _authenticationService;
    }
}
