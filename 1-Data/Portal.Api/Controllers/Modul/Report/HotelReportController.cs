using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MioPortal.Api.Data.Entity.ClientEntity;
using Newtonsoft.Json;
using Portal.Api.DataServis;
using System.Threading.Tasks;

namespace MioPortal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class HotelReportController : ControllerBase
    {
        IHotelService hotelService;
        public HotelReportController(IHotelService _hotelService)
        {
            hotelService = _hotelService;

        }

        [HttpPost]
        [Route("api/{controller}/GetHotelWebReportResult")]
        public async Task<ActionResult> GetHotelWebReportResult([FromBody] OtelReportRequest model)
        {

            var result = await hotelService.GetHotelWebReportResult(model);
            return Ok(result);
        }
    }
}
