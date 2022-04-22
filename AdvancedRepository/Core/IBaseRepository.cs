using AdvancedRepository.Models.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Core
{
    public interface IBaseRepository<T> where T: class
    {
        bool Update(T ent);
        bool Create(T ent);
        bool Delete(T ent);
        T Find(int id); //find metodu yazan yerlerde kullanılacak.
        T Find(int key1,int key2);
        //List<T> List();
        //void Save(); //savechanges yazan yerlerde kullanılacak.
        DbSet<T> Set(); //db.set yazan yerlerde kullanılacak.
        IQueryable<T> Qry(); //her türlü find list gibi nesneyi query yapılabilir yani döndürür. list find gibi nesnelerden tek farkı daha sonra müdahale edebiliyoruz.Tekrar sunucuya gitmeye gerek kalmayacak query sayesinde. 
        
    }
}
