using Cms.Core.Domains;
using Cms.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostRepository postRepository;

    public PostController(IPostRepository postRepository)
    {
        this.postRepository = postRepository;
    }

    [HttpGet("/getlatests/{count}")]
    public async Task<ActionResult<List<Post>>> Get(int count = 5) =>
        Ok(await postRepository.GetLatestPosts(count));
}
