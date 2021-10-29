using System.Threading.Tasks;
using TokenAuthentication.Entites;

using Microsoft.EntityFrameworkCore;
using TokenAuthentication.Data;

namespace TokenAuthentication.Repository
{
     public class AuthRepository: IAuthRepository
    {
        
        private readonly TokenDbContext _context;

        public AuthRepository(TokenDbContext context)
        {
            _context = context;
        }

        public async Task<Tbluser> Login(string email, string password)
        {
            var user = await _context.Tblusers.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.Password, user.Salt))
                return null;

            return user; // auth successful
        }

        public async Task<Tbluser> Register(Tbluser user, string password)
        {
            byte[] passwordHash, salt;
            CreatePasswordHash(password, out passwordHash, out salt);  //Encode
            user.Password = passwordHash;
            user.Salt = salt;

            await _context.Tblusers.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string Username)
        {
            if (await _context.Tblusers.AnyAsync(x => x.Email == Username))
                return true;
            return false;
        }
    }
}