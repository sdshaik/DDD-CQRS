using HackerRank.Monitoring.Api.Commands.RatingsCommands;
using HackerRank.Monitoring.Api.Query.RatingsQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HackerRank.Monitoring.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly ILogger<RatingsController> _logger;
        private readonly IMediator _mediatR;
        public RatingsController(IMediator mediator,
            ILogger<RatingsController> logger)
        {
            _mediatR = mediator;
            _logger = logger;
        }

        [HttpGet("GetRatingsAsync")]
        public async Task<IActionResult> GetRatingsAsync()
        {
            try
            {
                var res = await _mediatR.Send(new GetRatingsQuery());
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetRatingsAsync));
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetRatingsAsync([FromBody] SetRatingsCommand setRatingsCommand)
        {
            try
            {
                var test = await _mediatR.Send(setRatingsCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(SetRatingsAsync));
                throw;
            }
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRatingsByIdAsync([FromRoute] GetRatingsByIdQuery getRatingsByIdQuery)
        {
            try
            {
                var res = await _mediatR.Send(getRatingsByIdQuery);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetRatingsByIdAsync));
                throw;
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateRatingsAsync(UpdateRatingsCommand updateRatingsCommand)
        {
            try
            {
                var test = await _mediatR.Send(updateRatingsCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(UpdateRatingsAsync));
                throw;
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteRatingAsync([FromRoute] int Id)
        {
            try
            {
                var res = await _mediatR.Send(new DaleteRatingsCommand { Id = Id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(DeleteRatingAsync));
                throw;
            }
        }

    }
}
