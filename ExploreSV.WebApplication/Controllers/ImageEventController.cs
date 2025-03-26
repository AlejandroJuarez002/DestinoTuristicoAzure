using ExploreSV.BusinessLogic.UseCases.Images.Queries.GetImagesEvents;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ExploreSV.BusinessLogic.DTOs;
using Mapster;

namespace ExploreSV.WebApplication.Controllers
{
    [Authorize]
    public class ImageEventController : Controller
    {
        private readonly IMediator _mediator;

        public ImageEventController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var images = await _mediator.Send(new GetImagesEventsQuery());
            return View(images);
        }

    }
}
