using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class OtherProcessController : Controller
    {
        IOtherProcessService otherProcessService;
        public OtherProcessController(IOtherProcessService _otherProcessService)
        {
            otherProcessService = _otherProcessService;
        }
    }
}
