using AdvancedRepository.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Employees:Base,IAdres
    {
        public Employees()
        {
            Products = new HashSet<Products>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }
        public int? ManagerId { get; set; }
        public bool IsManager { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        public int CountryId { get; set; }
        public int OutDoorNumber { get; set; }
        public int PhoneNumber { get; set ; }
        public DateTime DateofBirth { get; set; }

        [ForeignKey("ManagerId")]
        public Employees Manager { get; set; }
        public List<Employees> Managers { get; set; }

        [ForeignKey("CountryId")]
        public Counties Country { get; set; }
        public ICollection<Products> Products { get; set; }


        //public string GetTitle()
        //{
        //    if (Gender == 'E')
        //    {
        //        return $"Sn Bay {FirstName} {LastName}";
        //    }
        //    else
        //    {
        //        return $"Sn Bayan {FirstName} {LastName}";
        //    }
        //}

    }
}
