using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class TourController : Controller
    {
        ITourService tourService;
        public TourController(ITourService _tourService)
        {
            tourService = _tourService;
        }
    }
}
