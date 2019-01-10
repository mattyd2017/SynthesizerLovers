using System.Collections.Generic;
using System.Threading.Tasks;
using SynthesizerLovers.API.Models;

namespace SynthesizerLovers.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
        
    }
}