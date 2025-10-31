using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecommerce.Models;
using ecommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext dbContext;

    public HomeController(ApplicationDbContext dbContext,ILogger<HomeController> logger)
    {
        this.dbContext = dbContext;
        _logger = logger;
    }

    public IActionResult Index()
    {
        // the admin dashboard will go here
        // make objects.get.all for this
        var users = dbContext.Users.ToList();
        return View(users);
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
