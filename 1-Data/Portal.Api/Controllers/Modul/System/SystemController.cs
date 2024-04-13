using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;
using System.Threading.Tasks;

namespace MioPortal.Api.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        ISystemService systemService;
        public SystemController(ISystemService _systemService)
        {
            systemService = _systemService;
        }

        [HttpPost]
        [Route("GetCompanyInfo")]
        public async Task<ActionResult> GetCompanyInfo()
        {
            var result = await systemService.GetCompanyInfo();
            return Ok(result);

        }
    }
}
