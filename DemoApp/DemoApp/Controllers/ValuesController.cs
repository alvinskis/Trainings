using DemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICalculationService _myCalculatioNService;
        private readonly BaseCalculator _baseCalculator;

        public ValuesController(ICalculationService myCalculatioNService)
        {
            _myCalculatioNService = myCalculatioNService;
            _baseCalculator = new CalculationServiceThree();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<double> Get()
        {
            return Ok(_myCalculatioNService.GetANumber());
        }

        // GET api/values
        [HttpGet("{id}")]
        public ActionResult<double> GetById(int id)
        {
            return Ok(_baseCalculator.Id);
        }
    }
}