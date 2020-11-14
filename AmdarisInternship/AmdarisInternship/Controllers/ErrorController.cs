using Microsoft.AspNetCore.Mvc;

namespace AmdarisInternship.API.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error() => Problem();
    }
}
