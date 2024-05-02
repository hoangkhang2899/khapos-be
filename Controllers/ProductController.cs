using AutoMapper;

using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;

using Microsoft.AspNetCore.Mvc;

namespace KhaPOS_BE.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;
    private readonly IMapper _mapper;
    public ProductController(IProductService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<ProductGetDto>>> Get()
    {
        var result = await _service.Get();
        return Ok(result);
    }

    [HttpPost("")]
    public async Task<ActionResult<Product>> Add(ProductAddDto dto)
    {
        var product = _mapper.Map<Product>(dto);
        var result = await _service.Add(product);
        return result;
    }
}