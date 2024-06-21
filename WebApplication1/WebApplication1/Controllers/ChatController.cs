using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ChatController : Controller
    {
        ITIContext db;
        public ChatController(ITIContext db)
        {
            this.db = db;
        }
       
        public IActionResult Index()
        {
            return View(db.Chats.ToList());
        }
    }
}
