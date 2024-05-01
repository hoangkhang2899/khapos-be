using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _service;
    public CategoryController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<Category>>> Get()
    {
        var result = await _service.Get();
        return Ok(result);
    }

    [HttpPost("")]
    public async Task<ActionResult<Category>> Add(Category category)
    {
        var result = await _service.Add(category);
        return result;
    }
}