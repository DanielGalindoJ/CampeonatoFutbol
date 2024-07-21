using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
      
        private readonly Lazy<IUsuarioRepository> _usuarioRepository;
       
        public RepositoryManager(RepositoryContext repositoryContext)
        {

            _usuarioRepository= new Lazy<IUsuarioRepository>(() => 
            new UsuarioRepository(repositoryContext));

        }

        public IUsuarioRepository User => _usuarioRepository.Value;
        
        
    }
}
