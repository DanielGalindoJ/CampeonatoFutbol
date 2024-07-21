using Entities.Models.Users;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUsuarioRepository
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetUser(Guid id, bool trackChanges);
   
          void DeleteUser(User user);
    }
}
