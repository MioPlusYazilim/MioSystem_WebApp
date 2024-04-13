using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Model.Utils;
using Portal.Api.DataServis;
using System.Threading.Tasks;

namespace Portal.Api.Controllers
{
    [Authorize]
    //[Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountService accountingService;
        public AccountController(IAccountService _accountingService)
        {
            accountingService = _accountingService;
        }

        [HttpPost]
        [Route("api/{controller}/GetCustomersSelectList")]
        public async Task<ActionResult> GetCustomersSelectList([FromBody] RequestType model)
        {
            var result = await accountingService.GetCustomerSelectList(model.typeID);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }

        [HttpPost]
        [Route("api/{controller}/GetCustomersGroupSelectList")]
        public async Task<ActionResult> GetCustomersGroupSelectList()
        {
            var result = await accountingService.GetCustomersGroupSelectList();
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }

        [HttpPost]
        [Route("api/{controller}/GetCustomerProjectSelectList")]
        public async Task<ActionResult> GetCustomerProjectSelectList()
        {
            var result = await accountingService.GetCustomerProjectSelectList();
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }
        [HttpPost]
        [Route("api/{controller}/GetCustomerCorporateSelectList")]
        public async Task<ActionResult> GetCustomerCorporateSelectList([FromBody] RequestType model)
        {
            var result = await accountingService.GetCustomerCorporateSelectList(model.typeID);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }

        [HttpPost]
        [Route("api/{controller}/GetCurrencySelectList")]
        public async Task<ActionResult> GetCurrencySelectList()
        {
            var result = await accountingService.GetCurrencySelectList();
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }
        [HttpPost]
        [Route("api/{controller}/GetCurrencyRateTypeSelectList")]
        public async Task<ActionResult> GetCurrencyRateTypeSelectList()
        {
            var result = await accountingService.GetCurrencyRateTypeSelectList();
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }

        [HttpPost]
        [Route("api/{controller}/GetSupplierChainSelectList")]
        public async Task<ActionResult> GetSupplierChainSelectList()
        {
            var result = await accountingService.GetSupplierChainSelectList();
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest("UserKey Eşleşmedi");
        }
    }
}
