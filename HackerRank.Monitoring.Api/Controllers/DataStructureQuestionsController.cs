using HackerRank.Monitoring.Api.Commands.DataStructureQuestionCommands;
using HackerRank.Monitoring.Api.Query.DataStructureQuestionsQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HackerRank.Monitoring.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureQuestionsController : ControllerBase
    {
        private readonly ILogger<DataStructureQuestionsController> _logger;
        private readonly IMediator _mediatR;
        public DataStructureQuestionsController(IMediator mediator,
            ILogger<DataStructureQuestionsController> logger)
        {
            _mediatR = mediator;
            _logger = logger;
        }

        [HttpGet("GetRatingsAsync")]
        public async Task<IActionResult> GetDataStructureQuestionsAsync()
        {
            try
            {
                var res = await _mediatR.Send(new GetDataStructureQuestionsQuery());
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetDataStructureQuestionsAsync));
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetDataStructureQuestionsAsync([FromBody] SetDataStructureQuestionsCommand setDataStructureQuestionsCommand)
        {
            try
            {
                var test = await _mediatR.Send(setDataStructureQuestionsCommand);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(SetDataStructureQuestionsAsync));
                throw;
            }
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetDataStructureQuestionByIdAsync([FromRoute] GetDataStructureQuestionsByIdQuery getDataStructureQuestionsByIdQuery)
        {
            try
            {
                var res = await _mediatR.Send(getDataStructureQuestionsByIdQuery);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(GetDataStructureQuestionByIdAsync));
                throw;
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateDataStructureQuestionsAsync(PutDataStructureQuestionsCommand putDataStructureQuestions)
        {
            try
            {
                var test = await _mediatR.Send(putDataStructureQuestions);
                return Ok(test);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(UpdateDataStructureQuestionsAsync));
                throw;
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteDataStructureQuestionsAsync([FromRoute] int Id)
        {
            try
            {
                var res = await _mediatR.Send(new DaleteDataStructureQuestionsCommand { Qus_Id = Id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured in {{0}}", nameof(DeleteDataStructureQuestionsAsync));
                throw;
            }
        }
    }
}
