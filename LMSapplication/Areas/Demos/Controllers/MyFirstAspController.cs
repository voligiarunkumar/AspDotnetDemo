using Microsoft.AspNetCore.Mvc;

namespace LMSapplication.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class MyFirstAspController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World");
            
        } 
        public IActionResult Index2()
        {
            return View();
            
        }
    }
}
