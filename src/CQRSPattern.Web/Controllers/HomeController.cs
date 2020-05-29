using CQRSPattern.Domain.Features.TransactionFeature.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSPattern.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            const int year = 2020;

            var handlerResult = await _mediator.Send(new GetBooksByYearQuery(year));

            var model = handlerResult.Data;

            return View(model);
        }
    }
}
