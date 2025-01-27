using Microsoft.AspNetCore.Mvc;

namespace BirthdayGiftSelector.Controllers
{
    public class VoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
