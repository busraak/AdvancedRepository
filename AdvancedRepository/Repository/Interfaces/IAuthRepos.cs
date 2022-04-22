using AdvancedRepository.Models.Classes;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IAuthRepos
    {
        void Register(string UserName,string Password);
        Users Login(string UserName, string Password);
        void Logout();
    }
}
