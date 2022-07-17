using AnimeFacts.Abstractions.Queries.GetAllAnimes.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AnimeFacts.API.Controllers;

[Route("api/[controller]")]
public class AnimeController : ControllerBase
{
    private IMediator _mediator;

    public AnimeController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet]
    [Route("get-all")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _mediator.Send(new GetAllAnimesRequest()));
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Error = ex.Message });
        }
    }


    [HttpGet]
    [Route("get-facts")]
    public async Task<IActionResult> GetFacts()
    {
        try
        {
            return Ok(await _mediator.Send(new GetAllAnimesRequest()));
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Error = ex.Message });
        }
    }
}
