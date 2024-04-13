using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class TransferController : Controller
    {
        ITransferService transferService;
        public TransferController(ITransferService _transferService)
        {
            transferService = _transferService;
        }
    }
}
