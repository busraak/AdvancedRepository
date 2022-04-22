using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class CitiesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CitiesModel _model;

        public CitiesController(IUnitOfWork unitOfWork,CitiesModel model)
        {
            _unitOfWork = unitOfWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x = _unitOfWork._cityRepos.Qry();
            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn-primary";
            _model.BtnHead = "Create";
            _model.BtnVal = "Create";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CitiesModel model)
        {
            _unitOfWork._cityRepos.Create(model.Cities);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success";
            _model.BtnHead = "Edit";
            _model.BtnVal = "Edit";
            _model.Cities = _unitOfWork._cityRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CitiesModel model)
        {
            _unitOfWork._cityRepos.Update(model.Cities);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnHead = "Delete";
            _model.BtnVal = "Delete";
            _model.Cities = _unitOfWork._cityRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CitiesModel model)
        {
            _unitOfWork._cityRepos.Delete(model.Cities);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("List");
        }
    }
}
