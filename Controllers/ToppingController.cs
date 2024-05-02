using AutoMapper;

using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToppingController : ControllerBase
{
    private readonly IToppingService _service;
    private readonly IMapper _mapper;
    public ToppingController(IToppingService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
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
        var topping = _mapper.Map<Topping>(dto);
        var result = await _service.Add(topping);
        return result;
    }
}