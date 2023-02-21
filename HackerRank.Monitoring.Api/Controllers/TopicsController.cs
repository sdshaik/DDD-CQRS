using HackerRank.Monitoring.Api.Commands.TopicsCommands;
using HackerRank.Monitoring.Api.Query.TopicsQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HackerRank.Monitoring.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ILogger<TopicsController> _logger;
        private readonly IMediator _mediatR;
        public TopicsController(IMediator mediator,
            ILogger<TopicsController> logger)
        {
            _mediatR = mediator;
            _logger = logger;
        }

        [HttpGet("GetTopicsAsync")]
        public async Task<IActionResult> GetTopicsAsync()
        {
            try
            {
                var res = await _mediatR.Send(new GetTopicsQuery());
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetTopicsAsync));
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetTopicsAsync([FromBody] SetTopicsCommand setTopicsCommand)
        {
            try
            {
                var test = await _mediatR.Send(setTopicsCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(SetTopicsAsync));
                throw;
            }
        }
    }
}
