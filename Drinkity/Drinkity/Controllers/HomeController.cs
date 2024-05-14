using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Drinkity.Models;

namespace Drinkity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Drinks> drinkMenu =
        [
            new Juice("Orange Juice", "oranges") {Image = "orangejuice.jpg"},
            new Beer("Budweiser", 5) {Image = "budweiser.jpeg"},
            new Soda("Pepsi") {Image = "pepsi.jpeg"},
        ];

        return View(drinkMenu);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
