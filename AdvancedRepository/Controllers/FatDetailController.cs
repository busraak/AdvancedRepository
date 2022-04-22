using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedRepository.Controllers
{
    public class FatDetailController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FatDetailModel _model;

        public FatDetailController(IUnitOfWork unitOfWork,FatDetailModel model)
        {
            _unitOfWork = unitOfWork;
            _model = model;
        }

        public IActionResult Create(int id)
        {
            _model.FatDetailList = _unitOfWork._fatDetailRepos.GetFatDetailLists(id); //eklenilen ürünlerin yukarıda listelenme hali
            _model.FatMaster=_unitOfWork._fatMasterRepos.Find(id);
            _model.ProductSelects = _unitOfWork._proRepos.GetProductSelects();
            _model.CustomerSelect=_unitOfWork._custRepos.GetCustomerSelects();
            _model.Total = _unitOfWork._fatDetailRepos.FatTotal(_model.FatDetailList); //toplam işlemi

            return View(_model);
        }
        [HttpPost]
        public IActionResult Create(int id,FatDetailModel model)
        {

            model.FatDetail.Id = id;
            _unitOfWork._fatDetailRepos.Create(model.FatDetail);
            _unitOfWork.Commit();
            model.FatMaster = _unitOfWork._fatMasterRepos.Find(id);
            model.ProductSelects=_unitOfWork._proRepos.GetProductSelects();
            model.CustomerSelect=_unitOfWork._custRepos.GetCustomerSelects();
            model.FatDetailList = _unitOfWork._fatDetailRepos.GetFatDetailLists(id); //eklenilen ürünlerin yukarıda listelenme hali
            
            model.Total = _unitOfWork._fatDetailRepos.FatTotal(model.FatDetailList); //toplam işlemi

            return View(model);

        }
        public IActionResult Edit(int id,int ProductId)
        {
           FatDetail fd= _unitOfWork._fatDetailRepos.Find(id,ProductId);
            //key sırasıyla verilmeli. İlki id, ikincisi productId
            return View(fd);
        }
        [HttpPost]
        public IActionResult Edit(FatDetail model, int id, int ProductId,bool d=true)
        {
            //hocanın çözümü
            //FatDetail fd = _unitOfWork._fatDetailRepos.Find(id, ProductId);
            //fd.Amount = model.Amount;
            //_unitOfWork._fatDetailRepos.Update(fd);
            //_unitOfWork.Commit();
            //_unitOfWork.Dispose();
            //return RedirectToAction("Create","FatDetail",new {id=id});
            model.Id = id;
            model.ProductId = ProductId;
            _unitOfWork._fatDetailRepos.Update(model);
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToAction("Create", "FatDetail", new { id,ProductId });


        }
    }
}
