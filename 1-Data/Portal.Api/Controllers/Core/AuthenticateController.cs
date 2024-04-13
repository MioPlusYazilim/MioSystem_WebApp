using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;
using Portal.Api.DataServis.GlobalContextService;
using Portal.Model;
using System.Threading.Tasks;
namespace Portal.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    public class AuthenticateController : ControllerBase
    {
        IAuthenticateService authService;
        IGlobalContextService globalContextService;
        public AuthenticateController(IAuthenticateService _authService, IGlobalContextService _globalContextService)
        {
            authService = _authService;
            globalContextService = _globalContextService;
        }
       
        [HttpPost]
        [Route("api/Login")]
        public async Task<ActionResult> Login([FromBody] LoginRequest model)
        {
            var result = await authService.Login(model.userName, model.userPassword);

            if (result.isSuccess)
                return Ok(result);
            else
            {
                result.errorMessage = globalContextService.GetSystemMessageValue("HataliKullanici").ToString();
                return BadRequest(result);
            }

           
        }

        [HttpPost]
        [Route("api/RefreshToken")]
        public async Task<ActionResult> RefreshToken([FromBody] refreshTokenRequest model)
        {
            var result = await authService.RefreshToken(model.requestValue);

            if (result.isSuccess)
                return Ok(result);
            else
            {
                result.errorMessage = globalContextService.GetSystemMessageValue(2).ToString();
                return BadRequest(result);
            }
        }

        [HttpPost]
        [Route("api/ForgatPassword")]
        public async Task<ActionResult> ForgatPassword([FromBody] forgatPasswordRequerst model)
        {
            var result = await authService.ForgatPassword(model.requestValue);

            if (result.isSuccess == false)
                return BadRequest(new { message = "Geçersiz email" });

            return Ok();
        }

        [HttpPost]
        [Route("api/ResetPassword")]
        public async Task<ActionResult> ResetPassword([FromBody] passwordResetRequest model)
        {
            var result = await authService.ResetPassword(model);

            if (result.isSuccess == false)
                return BadRequest(new { message = "Geçersiz Talep...." });

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("api/CrypText")]
        public ActionResult CrypText([FromBody] crypTextRequest model)
        {
            return Ok(authService.Sifrele(model.requestValue));
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("api/DeCrypText")]
        public ActionResult DeCrypText([FromBody] crypTextRequest model)
        {
            return Ok(authService.SifreCoz(model.requestValue));
        }
    }
}
