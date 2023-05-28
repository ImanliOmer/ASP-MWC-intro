using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.About;



namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var ours = new List<Our>
            {
                new Our { Id = 1 , Title = "Our Vision" , Desc = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."},
                new Our { Id = 2 , Title = "Our Mission" , Desc = "Eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam quis."},
                new Our { Id = 3 , Title = "Our Goal" , Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor."}
            };

            var model = new AboutIndexVM
            {
                Ours = ours
            };


            return View();
        }
    }
}
