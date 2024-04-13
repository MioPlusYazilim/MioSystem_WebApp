using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MioPortal.Api.Data.Entity.ClientEntity;
using Newtonsoft.Json;
using Portal.Api.DataServis;
using Portal.Api.DataServis.GlobalContextService;
using System.Threading.Tasks;

namespace MioPortal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class FlightTicketReportController : ControllerBase
    {
        IFlightTicketService flightService;
        public FlightTicketReportController(IFlightTicketService _flightService)
        {
            flightService = _flightService;
        }

        [HttpPost]
        [Route("api/{controller}/GetFlightTicketWebReportResult")]
        public async Task<ActionResult> GetFlightTicketWebReportResult([FromBody] TicketReportRequest model)
        {
            var result = await flightService.GetFlightTicketWebReportResult(model);
            return Ok(result);
        }

    }
}
