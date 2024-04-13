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
    public class AccountWebReportController : ControllerBase
    {
        IAccountService accountService;
        public AccountWebReportController(IAccountService _accountService)
        {
            accountService = _accountService;

        }

        [HttpPost]
        [Route("api/{controller}/GetInvoiceReportRequestResult")]
        public async Task<ActionResult> GetInvoiceReportRequestResult([FromBody] InvoiceReportRequest model)
        {
            var result = await accountService.GetInvoiceWebReportResult(model);
            return Ok(result);


        }
        [HttpPost]
        [Route("api/{controller}/GetModulWebReportResult")]
        public async Task<ActionResult> GetModulWebReportResult([FromBody] ModuleReportRequest model)
        {
            var result = await accountService.GetModulWebReportResult(model);
            return Ok(result);
        }

        [HttpPost]
        [Route("api/{controller}/GetWebReportMounthlyDashBoardResult")]
        public async Task<ActionResult> GetWebReportMounthlyDashBoardResult()
        {
            var result = await accountService.GetWebReportMounthlyDashBoardResult();
            return Ok(result);
        }

        [HttpPost]
        [Route("api/{controller}/GetWebReportDailyTransactionResult")]
        public async Task<ActionResult> GetWebReportDailyTransactionResult()
        {
            var result = await accountService.GetWebReportDailyTransactionResult();
            return Ok(result);
        }

        [HttpPost]
        [Route("api/{controller}/GetInvoiceCheckResult")]
        public async Task<ActionResult> GetInvoiceCheckResult([FromBody] InvoiceCheckRequest model)
        {
            var result = await accountService.GetInvoiceCheckResult(model);
            return Ok(result);
        }
    }
}
