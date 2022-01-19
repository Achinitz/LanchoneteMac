using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LanchesMac.Models;
using LanchesMac.ViewModels;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Controllers{

public class HomeController : Controller
{

    private readonly ILancheRepository _lancheRepository;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }

    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel{
            LanchesPreferidos = _lancheRepository.LanchesPreferidos
        };

        TempData["Nome"]= "Gustavo";

        return View(homeViewModel);
    }

    public IActionResult Demo()
    {
        return View();
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

}