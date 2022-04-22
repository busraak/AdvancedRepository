using AdvancedRepository.DTOs;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly ProductsModel _model;
       

        public ProductsController(IUnitOfWork unitofWork,ProductsModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x = _unitofWork._proRepos.GetProductList();
            return View(x);
        }
        public IActionResult Create()
        {
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            _model.SuppliersList = _unitofWork._supRepos.GetCompanyList();
            _model.CategoriesList = _unitofWork._catRepos.GetCategoryList();
            _model.UnitList = _unitofWork._unitRepos.GetUnitList();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(ProductsModel model)
        {
            _unitofWork._proRepos.Create(model.Products);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.SuppliersList = _unitofWork._supRepos.GetCompanyList();
            _model.CategoriesList = _unitofWork._catRepos.GetCategoryList();
            _model.UnitList = _unitofWork._unitRepos.GetUnitList();
            _model.Products = _unitofWork._proRepos.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Edit(ProductsModel model)
        {
            _unitofWork._proRepos.Update(model.Products);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.SuppliersList = _unitofWork._supRepos.GetCompanyList();
            _model.CategoriesList = _unitofWork._catRepos.GetCategoryList();
            _model.UnitList = _unitofWork._unitRepos.GetUnitList();
            _model.Products = _unitofWork._proRepos.Find(id);
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(ProductsModel model)
        {
            _unitofWork._proRepos.Delete(model.Products);
            _unitofWork.Commit();
            _unitofWork.Dispose();

            return RedirectToAction("List");
        }
        public IActionResult ListByCategoryId(int id)
        {
            //var pList = _proRepos.Set().Select(x => new ProductList
            //{
            //    ProductId = x.Id,
            //    ProductName = x.ProductName,
            //    CompanyName = x.Suppliers.CompanyName,
            //    CategoryName = x.Categories.CategoryName,
            //    UnitName = x.Unit.UnitName,
            //    CategoryId=x.CategoryId


            //}).Where(x => x.CategoryId == id).ToList();
            //return View("List", pList);mokmç 
            var x = _unitofWork._proRepos.Set().Where(x => x.CategoryId == id).Include(x => x.Categories).ToList();
            return View(x);
        }

    }
}
