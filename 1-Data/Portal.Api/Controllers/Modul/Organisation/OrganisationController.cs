using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class OrganisationController : Controller
    {
        IOrganisationService organisationService;
        public OrganisationController(IOrganisationService _organisationService)
        {
            organisationService = _organisationService;
        }
    }
}
