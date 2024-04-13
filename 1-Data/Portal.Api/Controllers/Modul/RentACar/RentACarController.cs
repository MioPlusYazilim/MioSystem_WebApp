using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class RentACarController : Controller
    {
        IRentACarService rentACarService;
        public RentACarController(IRentACarService _rentACarService)
        {
            rentACarService = _rentACarService;
        }
    }
}
