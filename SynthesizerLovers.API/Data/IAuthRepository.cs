using System.Threading.Tasks;
using SynthesizerLovers.API.Models;

namespace SynthesizerLovers.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}