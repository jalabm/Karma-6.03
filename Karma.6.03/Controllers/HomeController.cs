using Microsoft.AspNetCore.Mvc;

namespace Karma._6._03.Controllers;

public class HomeController : Controller
{ 

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Category()
    {
        return View();
    }

}

