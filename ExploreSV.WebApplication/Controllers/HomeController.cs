using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExploreSV.WebApplication.Models;
using MediatR;
using ExploreSV.BusinessLogic.UseCases.Categories.Queries.GetCategories;
using ExploreSV.BusinessLogic.UseCases.Categories.Commands.CreateCategory;
using ExploreSV.BusinessLogic.DTOs;

namespace ExploreSV.WebApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ISender _sender;

    public HomeController(ILogger<HomeController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }

    public  IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
