using KhaPOS_BE.Interfaces;

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
    public IActionResult Get()
    {
        return Ok();
    }
}