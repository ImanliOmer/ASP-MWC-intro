using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.Home;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var works = new List<Work>
            {
                new Work { Id = 1, Title = "Social Media", Description = "Social Media Desc" ,PhotoPath = "/assets/img/recent-work-01.jpg"},
                new Work { Id = 2, Title = "Web Marketing", Description = "Social Media Desc" ,PhotoPath = "./assets/img/recent-work-02.jpg"},
                new Work { Id = 3, Title = "R & D", Description = "Social Media Desc" ,PhotoPath = "/assets/img/recent-work-03.jpg"},
                new Work { Id = 4, Title = "Public Relation", Description = "Social Media Desc" ,PhotoPath = "/assets/img/recent-work-04.jpg"},
                new Work { Id = 5, Title = "Branding", Description = "Social Media Desc" ,PhotoPath = "/assets/img/recent-work-05.jpg"},
                new Work { Id = 6, Title = "Creative Design", Description = "Social Media Desc" ,PhotoPath = "/assets/img/recent-work-06.jpg"}
            };

            var model = new HomeIndexVM
            {
                WorkTitle = "Recent Works",
                Works = works,
            };

            return View(model);
        }
    }
}