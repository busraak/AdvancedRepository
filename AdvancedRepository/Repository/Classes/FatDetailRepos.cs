using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Classes
{
    public class FatDetailRepos:BaseRepository<FatDetail>,IFatDetailRepos
    {
        public FatDetailRepos( SirketContext db):base(db)
        {

        }

        public string FatTotal(IQueryable<FatDetailList> fd)
        {
            decimal Total = fd.Sum(x=>x.Amount*x.UnitPrice);
            int count = fd.Count();
            return $"Invoice Totals:{count} numbers of Products together with total amount of {Total}";

        }

        public IQueryable<FatDetailList> GetFatDetailLists(int id)
        {
            //asagıda commentlenen sekilde yani listleyerek yapılabilir. Ancak biz bu list i  toplam kısmında tekrar kullanacagız. Tekrar sunucuya gitmek yerine(perfromans kaybı) Qry yaptık. (qry ibase de ayrıntılı acıklandı.)
            var list = Qry(); 
            list = list.Where(z => z.Id == id);
            //var list = List();
            //list = list.Where(z => z.Id == id).ToList();

            var l=list.Select(x => new FatDetailList
            {
                Id= id,
                ProductId=x.ProductId,
                UnitPrice=x.DPrice,
                Amount=x.Amount,
                Total=x.DPrice*x.Amount,
                ProductName=x.Product.ProductName

                
            });
            return l;

        }
    }
}
