using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;

namespace AdvancedRepository.Repository.Classes
{
    public class AuthRepos : IAuthRepos
    {
        private readonly Users _users;
        private readonly SirketContext _db;

        public AuthRepos(Users users,SirketContext db)
        {
            _users = users;
            _db = db;
        }
        public Users Login(string UserName, string Password)
        {
            var user = _db.Set<Users>().Find(UserName);
            if (user != null)
            {
                bool verified = BCrypt.Net.BCrypt.Verify(Password, user.Password);
                if (verified)
                {
                    return user;
                }
                else return null;
            }
            else return null;
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }

        public void Register(string UserName, string Password)
        {
            _users.UserName= UserName;
            _users.Password= BCrypt.Net.BCrypt.HashPassword(Password);
            _users.Role = "users";
            _db.Set<Users>().Add(_users);
            _db.SaveChanges();
        }
    }
}
