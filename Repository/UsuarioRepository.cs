using Contracts;
using Entities.Models;
using Entities.Models.Users;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository : RepositoryBase<User>, IUsuarioRepository
    {
        public UsuarioRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

       

        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.LastName)
                .ToList();

        public User GetUser(Guid IdUsuario, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(IdUsuario), trackChanges)
            .SingleOrDefault();

      
        public void DeleteUser(User user) => Delete(user);

    }
}
