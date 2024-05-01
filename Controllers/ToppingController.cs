using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToppingController : ControllerBase
{
    private readonly IToppingService _service;
    public ToppingController(IToppingService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<Topping>>> Get()
    {
        var result = await _service.Get();
        return Ok(result);
    }

    [HttpPost("")]
    public async Task<ActionResult<Topping>> Add(ToppingAddDto dto)
    {
        var result = await _service.Add(dto);
        return result;
    }
}