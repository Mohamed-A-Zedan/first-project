using day_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace day_1.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult register()
        {
            return View();
        }
        public IActionResult showAll()
        {
            List<register> registers = sampleData.Registers;
            return View("showAll", registers);
        }
        public IActionResult addForm()
        {
            return View("addForm");
        }
        public IActionResult addData(register register)
        {
            sampleData.AddRegister(register);
            if (register.WillAttend)
            {
                return View("Thank_you");
            }
            else
            {
                sampleData.RemoveAtendee(register);
                return Content("See You Later");
            }

        }

    }
}
