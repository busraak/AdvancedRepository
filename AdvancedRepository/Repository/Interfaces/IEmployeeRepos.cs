using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IEmployeeRepos:IBaseRepository<Employees>
    {
        IQueryable<EmployeesList> GetEmployeesList();
        IQueryable<ManagersList> GetManagerList();
        EmployeeDetail GetEmployeeDetail(int id);

        string GetTitle(int id);
        int GetAge(int id);
       

    }
}
