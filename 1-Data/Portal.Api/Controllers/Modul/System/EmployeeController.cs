using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portal.Api.DataServis;
using Portal.Model;
using System.Threading.Tasks;

namespace Portal.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        [HttpPost]
        [Route("EmployeeMainList")]
        public async Task<ActionResult> EmployeeMainList()
        {
            var list = await employeeService.EmployeeMainList();
            return Ok(list);

        }

        [HttpPost]
        [Route("GetEmployeeSelectList")]
        public async Task<ActionResult> GetEmployeeSelectList()
        {
            var list = await employeeService.GetEmployeeSelectList();
            return Ok(list);

        }


        [HttpPost]
        [Route("GetEmployee")]
        public async Task<ActionResult> GetEmployee([FromBody] int id)
        {
            var user = await employeeService.GetEmployee(id);
            if (user != null)
            {
                return Ok(user);
            }
            else
                return BadRequest();
        }


        [HttpPost]
        [Route("AddOrUpdateEmployee")]
        public async Task<ActionResult> AddOrUpdateEmployee([FromBody] Employee_Dto model)
        {
            var result = await employeeService.AddOrUpdateEmployee(model);
            if (result.isSuccess)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost]
        [Route("DeleteEmployee")]
        public async Task<ActionResult> DeleteEmployee([FromBody] int id)
        {
            var result = await employeeService.DeleteEmployee(id);
            if (result.isSuccess)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
