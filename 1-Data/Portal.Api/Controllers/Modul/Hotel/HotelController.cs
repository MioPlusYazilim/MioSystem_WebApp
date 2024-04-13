using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;
using System.Threading.Tasks;

namespace Portal.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class HotelController : ControllerBase
    {
        IHotelService hotelService;
        public HotelController(IHotelService _hotelService)
        {
            hotelService = _hotelService;
        }

    }
}
