using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Model.Utils;
using Portal.Api.DataServis.GlobalContextService;
using System.Threading.Tasks;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class GlobalSystemController : ControllerBase
    {
        IGlobalContextService globalService;
        public GlobalSystemController(IGlobalContextService _globalService)
        {
            globalService = _globalService;
        }

        [HttpPost]
        [Route("api/{controller}/GetAdminNavigationTree")]
        public async Task<ActionResult> GetAdminNavigationTree()
        {
            var list = await globalService.GetAdminNavigationTree();
            return Ok(list);

        }


        [HttpPost]
        [Route("api/{controller}/GetSystemMessageFromID")]
        public ActionResult GetSystemMessageFromID([FromBody] int id)
        {
            var msg = globalService.GetSystemMessageValue(id);
            return Ok(msg);

        }

        [HttpPost]
        [Route("api/{controller}/GetSystemMessageFromName")]
        public ActionResult GetSystemMessageFromName([FromBody] string name)
        {
            var msg = globalService.GetSystemMessageValue(name);
            return Ok(msg);

        }

        [HttpPost]
        [Route("api/{controller}/GetModuleSelectList")]
        public async Task<ActionResult> GetModuleSelectList()
        {
            var list = await globalService.GetModuleSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetAirlineSelectList")]
        public async Task<ActionResult> GetAirlineSelectList()
        {
            var list = await globalService.GetAirlineSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetAirportSelectList")]
        public async Task<ActionResult> GetAirportSelectList()
        {
            var list = await globalService.GetAirportSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetFlightCabinTypeSelectList")]
        public async Task<ActionResult> GetFlightCabinTypeSelectList()
        {
            var list = await globalService.GetFlightCabinTypeSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetFlightLineZoneSelectList")]
        public async Task<ActionResult> GetFlightLineZoneSelectList()
        {
            var list = await globalService.GetFlightLineZoneSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetFlightLineDistanceSelectList")]
        public async Task<ActionResult> GetFlightLineDistanceSelectList()
        {
            var list = await globalService.GetFlightLineDistanceSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetFlightDirectionSelectList")]
        public async Task<ActionResult> GetFlightDirectionSelectList()
        {
            var list = await globalService.GetFlightDirectionSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetProcessLocationSelectList")]
        public async Task<ActionResult> GetProcessLocationSelectList()
        {
            var list = await globalService.GetProcessLocationSelectList();
            return Ok(list);

        }

        


        [HttpPost]
        [Route("api/{controller}/GetFlightTicketStatusSelectList")]
        public async Task<ActionResult> GetFlightTicketStatusSelectList()
        {
            var list = await globalService.GetFlightTicketStatusSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetFlightTicketTypeSelectList")]
        public async Task<ActionResult> GetFlightTicketTypeSelectList()
        {
            var list = await globalService.GetFlightTicketTypeSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetBedTypeSelectList")]
        public async Task<ActionResult> GetBedTypeSelectList()
        {
            var list = await globalService.GetBedTypeSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetRoomTypeSelectList")]
        public async Task<ActionResult> GetRoomTypeSelectList()
        {
            var list = await globalService.GetRoomTypeSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetHostelTypeSelectList")]
        public async Task<ActionResult> GetHostelTypeSelectList()
        {
            var list = await globalService.GetHostelTypeSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetReservationStatusSelectList")]
        public async Task<ActionResult> GetReservationStatusSelectList()
        {
            var list = await globalService.GetReservationStatusSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetPaymentTypeSelectList")]
        public async Task<ActionResult> GetPaymentTypeSelectList()
        {
            var list = await globalService.GetPaymentTypeSelectList();
            return Ok(list);

        }
        [HttpPost]
        [Route("api/{controller}/GetPayerTypeSelectList")]
        public async Task<ActionResult> GetPayerTypeSelectList()
        {
            var list = await globalService.GetPayerTypeSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetLocationSelectList")]
        public async Task<ActionResult> GetLocationSelectList([FromBody] RequestType model)
        {
            var list = await globalService.GetLocationSelectList(model.typeID);
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetInvoiceGroupSelectList")]
        public async Task<ActionResult> GetInvoiceGroupSelectList()
        {
            var list = await globalService.GetInvoiceGroupSelectList();
            return Ok(list);

        }

        [HttpPost]
        [Route("api/{controller}/GetInvoiceTypeSelectList")]
        public async Task<ActionResult> GetInvoiceTypeSelectList()
        {
            var list = await globalService.GetInvoiceTypeSelectList();
            return Ok(list);

        }
    }
}
