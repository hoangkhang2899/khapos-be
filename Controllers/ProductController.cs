using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;
    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<Product>>> Get()
    {
        var result = await _service.Get();
        return Ok(result);
    }

    [HttpPost("")]
    public async Task<ActionResult<Product>> Add(Product product)
    {
        var result = await _service.Add(product);
        return result;
    }
}