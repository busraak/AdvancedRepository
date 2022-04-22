using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CustomersModel _model;

        public CustomersController(IUnitOfWork unitOfWork,CustomersModel model)
        {
            _unitOfWork = unitOfWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x=_unitOfWork._custRepos.GetCustomersList();
            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            _model.CountriesList = _unitOfWork._counRepos.GetCountryList();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CustomersModel model)
        {
            _unitOfWork._custRepos.Create(model.Customers);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.Customers = _unitOfWork._custRepos.Find(id);
            _model.CountriesList = _unitOfWork._counRepos.GetCountryList();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CustomersModel model)
        {
            _unitOfWork._custRepos.Update(model.Customers);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.Customers = _unitOfWork._custRepos.Find(id);
            _model.CountriesList = _unitOfWork._counRepos.GetCountryList();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CustomersModel model)
        {
            _unitOfWork._custRepos.Delete(model.Customers);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("List");
        }
    }
}
