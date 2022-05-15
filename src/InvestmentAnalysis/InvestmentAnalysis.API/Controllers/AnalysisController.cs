using InvestmentAnalysis.Application.Commands;
using InvestmentAnalysis.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InvestmentAnalysis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AnalysisController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetInvestimentAnalysisResponse>> GetAnalysisInvestment([FromQuery] GetInvestimentAnalysisCommand request)
        {
            var result = await _mediator.Send(request); 
            return Ok(result);
        }
    }
}
