using AdvancedRepository.Core;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;

namespace AdvancedRepository.Repository.Classes
{
    public class BasketMasterRepos:BaseRepository<BascetMaster>,IBasketMasterRepos
    {
        public BasketMasterRepos(SirketContext db):base(db)
        {

        }
    }
}
