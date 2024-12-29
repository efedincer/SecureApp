using Microsoft.AspNetCore.Mvc;

namespace SecureApp.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
