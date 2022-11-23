using Microsoft.AspNetCore.Mvc;
using BasicWebApp.Services;
namespace BasicWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromServices] Services.MetMumbaiDbContext db)
    {
        return View(db);
    }
}