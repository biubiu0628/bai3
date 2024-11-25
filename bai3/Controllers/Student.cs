using Microsoft.AspNetCore.Mvc;

namespace bai3.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowKQ(int id, string name, string nganh) {
            return Content(string.Format("Cam on ban {0}-{1} da dang ky chuyen nganh {2}.", id, name, nganh));
        }
    }
}
