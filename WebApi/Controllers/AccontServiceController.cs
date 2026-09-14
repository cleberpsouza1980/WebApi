using Microsoft.AspNetCore.Mvc;
using Web.Application.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccontServiceController : ControllerBase
    {
        private readonly IAccountPlanServices _accountService;

        public AccontServiceController(IAccountPlanServices accountPlanServices)
        {
            _accountService = accountPlanServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAccountAll()
        {
            
            var r = await _accountService.GetAllAccountPlansAsync();
            return Ok(r);
        }
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAccountById(int id)
        {
            var r = await _accountService.GetAllAccountByIdAsync(id);

            if(r==null)
                return NotFound();

            return Ok(r);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAccountById(int id)
        {
            await _accountService.DeleteAccountByIdAsync(id);
            
            return NoContent();
        }
    }
}
