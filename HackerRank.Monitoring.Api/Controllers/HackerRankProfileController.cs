using HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands;
using HackerRank.Monitoring.Api.Query.HackerRankProfileQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HackerRank.Monitoring.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HackerRankProfileController : ControllerBase
    {
        private readonly ILogger<HackerRankProfileController> _logger;
        private readonly IMediator _mediatR;
        public HackerRankProfileController(IMediator mediator,
            ILogger<HackerRankProfileController> logger)
        {
            _mediatR = mediator;
            _logger = logger;
        }

        [HttpGet("GetHackerRankProfileAsync")]
        public async Task<IActionResult> GetHackerRankProfileAsync()
        {
            try
            {
                var test = await _mediatR.Send(new GethackerRankProfileQuery());
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetHackerRankProfileAsync));
                throw;
            }
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetHackerRankProfileByIdAsync([FromRoute] GetHackerRankProfileByIdQuery getHackerRankProfileByIdQuery)
        {
            try
            {
                var res = await _mediatR.Send(getHackerRankProfileByIdQuery);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetHackerRankProfileByIdAsync));
                throw;
            }
        }

        [HttpGet("{Email}/GetByEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> GetHackerRankProfileByEmailAsync([FromRoute] GetHackerRankProfileByEmailQuery getHackerRankProfileByEmailQuery)
        {
            try
            {
                var res = await _mediatR.Send(getHackerRankProfileByEmailQuery);
                if (res == null)
                {
                    return NotFound("User with this email not found");
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetHackerRankProfileByEmailAsync));
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetHackerRankProfileAsync([FromBody] SetHackerRankProfileCommand setHackerRankProfileCommand)
        {
            try
            {
                var test = await _mediatR.Send(setHackerRankProfileCommand);
                if (test == 1)
                {
                    return Ok(test);
                }
                return BadRequest("User With this email is already exist");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(SetHackerRankProfileAsync));
                throw;
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateHackerRankProfileAsync(putHackerRankProfileCommand putHackerRankProfileCommand)
        {
            try
            {
                var test = await _mediatR.Send(putHackerRankProfileCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(UpdateHackerRankProfileAsync));
                throw;
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteHackerRankProfilAsync([FromRoute] int Id)
        {
            try
            {
                var res = await _mediatR.Send(new DeleteHackerRankProfileCommand { User_Id = Id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(UpdateHackerRankProfileAsync));
                throw;
            }
        }
    }
}
