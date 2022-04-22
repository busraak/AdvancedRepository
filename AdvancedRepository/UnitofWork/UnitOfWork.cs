using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        SirketContext _db;
  
        public UnitOfWork(SirketContext db
            ,IProductRepos proRepos
            ,IUnitRepos unitRepos
            ,ISupplierRepos supRepos
            ,IEmployeeRepos empRepos
            ,ICountryRepos counRepos
            ,ICityRepos cityRepos
            ,ICustomerRepos custRepos
            ,IFatMasterRepos fatMasterRepos
            ,IFatDetailRepos fatDetailRepos
            ,IAuthRepos authRepos
            ,IBasketMasterRepos basketMasterRepos
            ,IBasketDetailRepos basketDetailRepos)
            
        {
            _db = db;
            _catRepos = new CategoryRepos(db); // bu sekilde tanımlandıgında startupta servis olarak eklemeye gerek kalmaz.
            _proRepos = proRepos;
            _unitRepos = unitRepos;
            _supRepos = supRepos;
            _empRepos = empRepos;
            _counRepos = counRepos;
            _cityRepos = cityRepos;
            _custRepos = custRepos;
            _fatMasterRepos = fatMasterRepos;
            _fatDetailRepos = fatDetailRepos;
            _authRepos = authRepos;
            _basketDetailRepos = basketDetailRepos;
            _basketMasterRepos = basketMasterRepos;
        }
        public CategoryRepos _catRepos { get; private set; } //set degistirmeye yarar. Private bunu engeller

        public IProductRepos _proRepos { get; private set; }

        public IUnitRepos _unitRepos { get; private set; }
         
        public ISupplierRepos _supRepos { get; private set; }

        public IEmployeeRepos _empRepos { get; private set; }

        public ICountryRepos _counRepos { get; private set; }

        public ICityRepos _cityRepos { get; private set; }

        public ICustomerRepos _custRepos { get; private set; }

        public IFatMasterRepos _fatMasterRepos { get; private set; }

        public IFatDetailRepos _fatDetailRepos { get; private set; }

        public IAuthRepos _authRepos { get; private set; }

        public IBasketDetailRepos _basketDetailRepos { get; private set; }

        public IBasketMasterRepos _basketMasterRepos { get; private set; }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose(); //memory i oldugu gibi temizler.
        }
    }
}
