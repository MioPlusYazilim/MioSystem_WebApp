using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class FligthTicketController : ControllerBase
    {
        IFlightTicketService ticketService;
        public FligthTicketController(IFlightTicketService _ticketService)
        {
            ticketService = _ticketService;
        }
    }
}
