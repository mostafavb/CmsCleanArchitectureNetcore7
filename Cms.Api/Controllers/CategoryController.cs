using Cms.Core.Interfaces.Repository;
using Cms.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        this.categoryRepository = categoryRepository;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Category>> Get(int id)
    {
        try
        {
            var _category = await categoryRepository.Get(id);
            return Ok(_category);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post(Category category)
    {
        try
        {
            var cat = await categoryRepository.Add<Category>(category);
            return Ok(cat);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        
    }
}
