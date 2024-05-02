using AutoMapper;

using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _service;
    private readonly IMapper _mapper;
    public CategoryController(ICategoryService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    /// <summary>
    /// Get all category
    /// </summary>
    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<CategoryGetDto>>> Get()
    {
        var result = await _service.Get();
        return Ok(result);
    }

    /// <summary>
    /// Add new category
    /// </summary>
    [HttpPost("")]
    public async Task<ActionResult<Category>> Add(CategoryAddDto dto)
    {
        var category = _mapper.Map<Category>(dto);
        var result = await _service.Add(category);
        return result;
    }
}