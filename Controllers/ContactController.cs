using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("/contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}