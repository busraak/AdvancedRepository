using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class UnitsController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly UnitsModel _model;

        public UnitsController(IUnitOfWork unitofWork,UnitsModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x = _unitofWork._unitRepos.GetUnitList();
            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(UnitsModel model)
        {
            _unitofWork._unitRepos.Create(model.Units);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.Units = _unitofWork._unitRepos.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Edit(UnitsModel model)
        {
            _unitofWork._unitRepos.Update(model.Units);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.Units = _unitofWork._unitRepos.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(UnitsModel model)
        {
            _unitofWork._unitRepos.Delete(model.Units);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
    }
}
