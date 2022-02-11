using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet("/projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }
    }
}