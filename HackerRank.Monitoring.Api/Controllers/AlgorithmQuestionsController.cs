using HackerRank.Monitoring.Api.Commands.AlgorithmQuestionsCommands;
using HackerRank.Monitoring.Api.Query.AlgorithmQuestionsQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HackerRank.Monitoring.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlgorithmQuestionsController : ControllerBase
    {
        private readonly ILogger<AlgorithmQuestionsController> _logger;
        private readonly IMediator _mediatR;
        public AlgorithmQuestionsController(IMediator mediator,
            ILogger<AlgorithmQuestionsController> logger)
        {
            _mediatR = mediator;
            _logger = logger;
        }

        [HttpGet("GetAlgorithmQuestionsAsync")]
        public async Task<IActionResult> GetAlgorithmQuestionsAsync()
        {
            try
            {
                var res = await _mediatR.Send(new GetAlgorithmQuesionsQuery());
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetAlgorithmQuestionsAsync));
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetAlgorithmQuestionsAsync([FromBody] SetAlgorithmQuestionsCommand setAlgorithmQuestionsCommand)
        {
            try
            {
                var test = await _mediatR.Send(setAlgorithmQuestionsCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(SetAlgorithmQuestionsAsync));
                throw;
            }
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAlgorithmQuestionByIdAsync([FromRoute] GetAlgorithmQuesionsQueryById getAlgorithmQuesionsQueryById)
        {
            try
            {
                var res = await _mediatR.Send(getAlgorithmQuesionsQueryById);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetAlgorithmQuestionByIdAsync));
                throw;
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateAlgorithmQuestionsAsync(PutAlgorithmQuestionsCommand putAlgorithmQuestionsCommand)
        {
            try
            {
                var test = await _mediatR.Send(putAlgorithmQuestionsCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(UpdateAlgorithmQuestionsAsync));
                throw;
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAlgorithmQuestionsAsync([FromRoute] int Id)
        {
            try
            {
                var res = await _mediatR.Send(new DaleteAlgorithmQuestionsCommand { Qus_Id = Id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(DeleteAlgorithmQuestionsAsync));
                throw;
            }
        }
    }
}
