using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}