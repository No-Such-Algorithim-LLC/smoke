using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tpåwßƒ.Models;

namespace Tpåwßƒ.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Payment1()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Hat()
    {
        return View();
    }

    public IActionResult AShirt()
    {
        return View();
    }

    public IActionResult BShirt()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Intent()
    {
        return View();
    }

    public IActionResult IRLPortfolio()
    {
        return View();
    }

    public IActionResult Patch()

    {
        return View();
    }


    public IActionResult VRPortfolio()
       
    {
        return View();
    }

    public IActionResult Rank()

    {
        return View();
    }
    

   public IActionResult Tpåwßƒ()

    {
        return View();
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

