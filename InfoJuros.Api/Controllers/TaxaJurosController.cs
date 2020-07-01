using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InfoJuros.Api.Controllers
{
    [ApiController]
    [Route("/taxajuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var percTaxaJuros = 1;
            return Ok(new { percTaxaJurosMensal = percTaxaJuros });
        }
    }
}
