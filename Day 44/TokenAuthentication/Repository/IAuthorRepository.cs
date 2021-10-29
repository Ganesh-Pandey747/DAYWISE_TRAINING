using System.Threading.Tasks;
using TokenAuthentication.Entites;

namespace TokenAuthentication.Repository
{
    public interface IAuthRepository
    {

        Task<Tbluser> Register(Tbluser user, string password);
        Task<Tbluser> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}