using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        // TODO: Домашнее задание [Пункт 2]
        // В проект агента сбора метрик добавьте контроллеры для сбора метрик, аналогичные
        // менеджеру сбора метрик.Добавьте методы для получения метрик с агента, доступные по
        //следующим путям

        // a. api/metrics/cpu/from/{fromTime}/to/{toTime} [ВЫПОЛНИЛИ ВМЕСТЕ]
        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics(
            [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        
        
    }
}
