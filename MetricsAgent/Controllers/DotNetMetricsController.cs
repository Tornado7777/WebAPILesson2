using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        // b. api / metrics / dotnet / errors - count / from /{ fromTime}/ to /{ toTime}
        [HttpGet("errors-count/from/{ fromTime}/to/{ toTime}")]
        public IActionResult GetMetrics(
            [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
