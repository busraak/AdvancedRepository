using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly EmployeeModel _model;

        public EmployeesController(IUnitOfWork unitofWork,EmployeeModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x = _unitofWork._empRepos.GetEmployeesList();

            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            _model.CountriesList = _unitofWork._counRepos.Qry();
            _model.ManagerList = _unitofWork._empRepos.GetManagerList();
            
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(EmployeeModel model)
        {
            _unitofWork._empRepos.Create(model.Employees);
            _unitofWork.Commit();
            _unitofWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.CountriesList = _unitofWork._counRepos.Qry();
            _model.ManagerList = _unitofWork._empRepos.GetManagerList();
            _model.Employees = _unitofWork._empRepos.Find(id);

            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeModel model)
        {
            _unitofWork._empRepos.Update(model.Employees);
            _unitofWork.Commit();
            _unitofWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.CountriesList = _unitofWork._counRepos.Qry();
            _model.ManagerList = _unitofWork._empRepos.GetManagerList();
            _model.Employees = _unitofWork._empRepos.Find(id);

            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(EmployeeModel model)
        {
            _unitofWork._empRepos.Delete(model.Employees);
            _unitofWork.Commit();
            _unitofWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Detail(int id)
        {
            var emp = _unitofWork._empRepos.GetEmployeeDetail(id);
            return View(emp);

        }
    }
}
