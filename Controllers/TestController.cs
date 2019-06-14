using Microsoft.AspNetCore.Mvc;
namespace PortfolioOne.Controllers
{
    public class TestController : Controller {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects() {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact() {
            return View();
        }
    }
}