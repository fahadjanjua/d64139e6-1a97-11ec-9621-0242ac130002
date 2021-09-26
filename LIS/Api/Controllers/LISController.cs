using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using API.Service;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LISController : ControllerBase
    {
        private readonly ILISService _service;
        public LISController(ILISService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] string input)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    return BadRequest("Input is required.");
                }
                    
                var result = await _service.FindLIS(input); //Input is not empty let's find the LIS from the LIS service.
                return Ok(result); //return the LIS result as the Http 200 OKObjectResult
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError); //For any exception thrown return the Http 500 Internal Server Error to the client
            }
        }
    }
}
