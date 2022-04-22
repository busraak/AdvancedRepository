using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class CountiesController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly CountriesModel _model;

        public CountiesController(IUnitOfWork unitofWork,CountriesModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x = _unitofWork._counRepos.GetCountryList();
            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            _model.CitiesList = _unitofWork._cityRepos.Qry();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CountriesModel model)
        {
            _unitofWork._counRepos.Create(model.Counties);
            _unitofWork.Commit();
            _unitofWork.Dispose();
            return RedirectToAction("List");

        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.CitiesList = _unitofWork._cityRepos.Qry();
            _model.Counties = _unitofWork._counRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CountriesModel model)
        {
            _unitofWork._counRepos.Update(model.Counties);
            _unitofWork.Commit();
            _unitofWork.Dispose();
            return RedirectToAction("List");

        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Danger";
            _model.BtnHead = "Danger";
            _model.CitiesList = _unitofWork._cityRepos.Qry();
            _model.Counties = _unitofWork._counRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CountriesModel model)
        {
            _unitofWork._counRepos.Delete(model.Counties);
            _unitofWork.Commit();
            _unitofWork.Dispose();
            return RedirectToAction("List");

        }
    }
}
