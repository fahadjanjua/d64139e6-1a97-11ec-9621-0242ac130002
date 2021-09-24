using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using LIS.Common;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LIS.API.Controllers
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
                    

                var result = await _service.FindLIS(input);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
