using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class VisaController : Controller
    {
        IVisaService visaService;
        public VisaController(IVisaService _visaService)
        {
            visaService = _visaService;
        }
    }
}
