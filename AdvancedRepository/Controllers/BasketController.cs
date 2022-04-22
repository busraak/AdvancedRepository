using AdvancedRepository.DTOs;
using AdvancedRepository.Extensions;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdvancedRepository.Controllers
{
    public class BasketController : Controller
    {
        private  readonly IUnitOfWork _unitOfWork;
        //private static  List<BasketList> _basket;
        private readonly BasketModel _model;
        private readonly BasketList _basketList;

        public BasketController(IUnitOfWork unitOfWork,List<BasketList> basket,BasketModel model, BasketList basketList)
        {
            _unitOfWork = unitOfWork;
            //_basket = basket;
            _model = model;
            _basketList = basketList;
        }
        static List<BasketList> _basket = new List<BasketList>();
        public IActionResult List()
        {

            return View(_basket);
        }

        public IActionResult AddProducts()
        {
            _model.ProductSelect=_unitOfWork._proRepos.GetProductSelects();
            return View(_model);
        }

        [HttpPost]
        public IActionResult AddProducts(BasketModel model)
        {
            Products product= _unitOfWork._proRepos.Find(model.Id);
            _basketList.Id=product.Id;
            _basketList.ProductName = product.ProductName;
            _basketList.Amount = model.Amount;
            _basketList.UnitPrice = product.UnitPrice;
            //buraya kadar sepetim olustu. urunumu miktarımı sectim.(list degil.cunku bir urun ekleniyor burada.)

            _basket.Add(_basketList); // sectiğim ürünleri sepete ekliyorum(list oldugu icin birden fazla urun eklenebilir)
            HttpContext.Session.Set("Basket", _basket); //extentions kullanıldı. list basketi bi json nesnesi bunu tırnaklıyor ve string e donusturuyor.
            //_basket = HttpContext.Session.Get<List<BasketList>>("Basket"); //extentions kullanıldı. list basketi bi json nesnesi bunu tırnaklıyor ve string e donusturuyor.
            //ViewBag.Count=_basket.Count;

            return RedirectToAction("Index","Home");
        }
    }
}
