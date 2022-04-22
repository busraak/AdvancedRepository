using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.UnitofWork
{
    public interface IUnitOfWork
    {
        CategoryRepos _catRepos { get; }
        IProductRepos _proRepos { get; }
        IUnitRepos _unitRepos { get; }
        ISupplierRepos _supRepos { get; }
        IEmployeeRepos _empRepos { get; }
        ICountryRepos _counRepos { get; }
        ICityRepos _cityRepos { get; }
        ICustomerRepos _custRepos { get; }
        IFatMasterRepos _fatMasterRepos { get; }
        IFatDetailRepos _fatDetailRepos { get; }
        IAuthRepos _authRepos { get; }
        IBasketDetailRepos _basketDetailRepos { get; }

        IBasketMasterRepos _basketMasterRepos { get; }



        void Commit(); //savechanges anlamı
        void Dispose(); //memory de bir şeyler varsa silmeye yarar. Dispose kelime anlamı: öldürmek
    }
}
