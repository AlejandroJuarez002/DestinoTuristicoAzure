using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.BusinessLogic.UseCases.TouristDestinations.Queries.GetTouristDestinations;
using ExploreSV.BusinessLogic.UseCases.Gastronomies.Commands.CreateGastronomy;
using ExploreSV.BusinessLogic.UseCases.Gastronomies.Commands.UpdateGastronomy;
using ExploreSV.BusinessLogic.UseCases.Gastronomies.Commands.DeleteGastronomy;
using Microsoft.AspNetCore.Mvc;

namespace ExploreSV.WebApplication.Controllers
{
    public class GastronomyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
