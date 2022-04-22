using AdvancedRepository.Extensions;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.UnitofWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedRepository.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly LoginModel _model;

        public AuthController(IUnitOfWork unitOfWork,LoginModel model)
        {
            _unitOfWork = unitOfWork;
            _model = model;
        }
        public IActionResult Register()
        {
            return View(_model);
        }
        [HttpPost]
        public IActionResult Register(LoginModel model)
        {
            _unitOfWork._authRepos.Register(model.UserName,model.Password);
            return RedirectToAction("Index","Home");
        }
        public IActionResult Login()
        {
            return View("Register", _model);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            Users user=_unitOfWork._authRepos.Login(model.UserName,model.Password);
            if (user != null)
            {
                HttpContext.Session.Set<string>("UserName",user.UserName); //set<string> extentions kullanıldı. stringe cevirdi
                HttpContext.Session.Set<string>("Role", user.Role);

                return RedirectToAction("Index", "Home");
            }
            else return RedirectToAction("Login");



        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); //hepsini temizler

            //sepet haric her seyi temizler
            //HttpContext.Session.Set("UserName", "");
            //HttpContext.Session.Set("Role", "");

            return RedirectToAction("Index","Home");
        }
    }
}
