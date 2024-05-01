using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _service;
    public TransactionController(ITransactionService service)
    {
        _service = service;
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
        var result = await _service.Add(dto);
        return result;
    }
}