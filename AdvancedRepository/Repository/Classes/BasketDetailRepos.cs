using AdvancedRepository.Core;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;

namespace AdvancedRepository.Repository.Classes
{
    public class BasketDetailRepos:BaseRepository<BascetDetail>,IBasketDetailRepos
    {
        public BasketDetailRepos(SirketContext db):base(db)
        {

        }
    }
}
