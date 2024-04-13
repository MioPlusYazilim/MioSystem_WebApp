using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MioPortal.Api.DataServis;
using Portal.Model.Utils;
using System.Threading.Tasks;

namespace MioPortal.Api.Controllers
{
    [Authorize]
    //[Route("api/[controller]")]
    [ApiController]
    public class ClientDefinitionsController : ControllerBase
    {
        IClientDefinitionsService clientDefinitionsService;
        public ClientDefinitionsController(IClientDefinitionsService _clientDefinitionsService)
        {
            clientDefinitionsService = _clientDefinitionsService;
        }

        [HttpPost]
        [Route("api/{controller}/GetTransactionStatusSelectList")]
        public async Task<ActionResult> GetTransactionStatusSelectList([FromBody] RequestType model)
        {
            var result = await clientDefinitionsService.GetTransactionStatusSelectList(model.typeID);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }
        [HttpPost]
        [Route("api/{controller}/GetPositionSelectList")]
        public async Task<ActionResult> GetPositionSelectList()
        {
            var result = await clientDefinitionsService.GetPositionSelectList();
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }
        [HttpPost]
        [Route("api/{controller}/GetSpecialCodeSelectList")]
        public async Task<ActionResult> GetSpecialCodeSelectList([FromBody] RequestType model)
        {
            var result = await clientDefinitionsService.GetSpecialCodeSelectList(model.typeID);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }
    }
}

