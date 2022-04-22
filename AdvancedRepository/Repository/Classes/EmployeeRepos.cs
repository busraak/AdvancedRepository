using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class EmployeeRepos : BaseRepository<Employees>, IEmployeeRepos
    {
        public EmployeeRepos(SirketContext db) : base(db)
        {

        }

        public int GetAge(int id)
        {
            Employees emp = Find(id);
            var today = DateTime.Now;
            var age = today.Year - emp.DateofBirth.Year;
            var birthday = emp.DateofBirth.AddYears(age);

            if (birthday > today)
            {
                age--;
            }
            return age;
        }
        public string GetTitle(int id)
        {
            Employees emp = Find(id);
            if (emp.Gender == 'E')
            {
                return "Sn Bay" +" "+ emp.FirstName + " " + emp.LastName;
            }
            else
            {
                return "Sn Bayan"+" " + emp.FirstName + " " + emp.LastName;

            }
        }
        public IQueryable<EmployeesList> GetEmployeesList()
        {
            return Set().Select(x => new EmployeesList
            {
                EmployeeId = x.Id,
                FullName = x.FirstName+ " " + x.LastName,
                ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                CountryName = x.Country.CountryName,
                PhoneNumber = x.PhoneNumber

            });
        }
        public IQueryable<ManagersList> GetManagerList()
        {
            
            return Set().Select(x => new ManagersList
            {
                IsManager=x.IsManager,
                ManagerId=x.Id,
                FullName = x.FirstName + " " + x.LastName
                
            }).Where(x=>x.IsManager==true);
        }

        public EmployeeDetail GetEmployeeDetail(int id)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail();
            employeeDetail.Head = $"{ GetTitle(id)}  Yaşı: {GetAge(id)}";
            employeeDetail.Id = id;
            return employeeDetail;
           
        }
    }
}
