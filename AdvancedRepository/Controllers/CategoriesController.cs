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

    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly CategoriesModel _model;

        public CategoriesController(IUnitOfWork unitofWork,CategoriesModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
           var x=_unitofWork._catRepos.GetCategoryList();
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
        public IActionResult Create(CategoriesModel model)
        {
            _unitofWork._catRepos.Create(model.Categories);
            _unitofWork.Commit();
            _unitofWork.Dispose(); //eger kullanmazsak editten cıktıktan sonra temizliyor. kullanırsak su an
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success"; 
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.Categories = _unitofWork._catRepos.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Edit(CategoriesModel model)
        {
            _unitofWork._catRepos.Update(model.Categories);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.Categories = _unitofWork._catRepos.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(CategoriesModel model)
        {
            _unitofWork._catRepos.Delete(model.Categories);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
    }
}
