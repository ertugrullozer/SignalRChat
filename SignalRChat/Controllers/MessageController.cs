using Microsoft.AspNetCore.Mvc;

namespace SignalRChat.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
