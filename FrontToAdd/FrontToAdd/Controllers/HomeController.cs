using FrontToAdd.Models;
using FrontToAdd.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToAdd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<slider> sliders = new List<slider>
            {
                new slider{Id= 1,Title = " Title 1", Discription = "finaly it works", ImgUrl = "carousel-1.jpg", RedirectUrl = "www.google.com",RedirectUrl2="www.google.com"},
                new slider{Id= 2,Title = " Title 2", Discription = "finaly it doesnt works", ImgUrl = "carousel-2.jpg", RedirectUrl = "www.google.com",RedirectUrl2="www.google.com"},
                new slider{Id= 3,Title = " Title 3", Discription = "finaly it work now", ImgUrl = "carousel-3.jpg", RedirectUrl = "www.google.com",RedirectUrl2="www.google.com"},
                };

            List<SecurityService> securityService = new List<SecurityService>
            {
                new SecurityService{Id= 1,Title = " Title 1", Description = "finaly it works", Icon = "<i class=\"flaticon-cctv d-block display-1 fw-normal text-secondary mb-3\"></i>", redirectUrl = "www.google.com"},
                new SecurityService{Id= 2,Title = " Title 2", Description = "finaly it doesnt works", Icon = "<i class=\"flaticon-cctv d-block display-1 fw-normal text-secondary mb-3\"></i>", redirectUrl = "www.google.com"},
                new SecurityService{Id= 3,Title = " Title 3", Description = "finaly it work now", Icon = "<i class=\"flaticon-security-system d-block display-1 fw-normal text-secondary mb-3\"></i>", redirectUrl = "www.google.com"},
                new SecurityService{Id= 4,Title = " Title 4", Description = "finaly it works", Icon = "<i class=\"flaticon-cctv d-block display-1 fw-normal text-secondary mb-3\"></i>", redirectUrl = "www.google.com"},
                new SecurityService{Id= 5,Title = " Title 5", Description = "finaly it doesnt works", Icon = "<i class=\"flaticon-cctv d-block display-1 fw-normal text-secondary mb-3\"></i>", redirectUrl = "www.google.com"},
                new SecurityService{Id= 6,Title = " Title 6", Description = "finaly it work now", Icon = "<<i class=\"flaticon-security-system d-block display-1 fw-normal text-secondary mb-3\"></i>", redirectUrl = "www.google.com"},

            };
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = sliders,
                SecurityServices = securityService
            };


            return View(homeViewModel);
        }
    }
}
