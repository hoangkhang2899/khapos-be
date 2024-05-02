using AutoMapper;

using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _service;
    private readonly IMapper _mapper;
    public TransactionController(ITransactionService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<Transaction>>> Get()
    {
        var result = await _service.Get();
        return Ok(result);
    }

    [HttpPost("")]
    public async Task<ActionResult<Transaction>> Add(TransactionAddDto dto)
    {
        var transaction = _mapper.Map<Transaction>(dto);
        var result = await _service.Add(transaction);
        return result;
    }
}