using Cms.Core.Models;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Cms.Core.Features.Queries.Posts;
using Cms.Core.Features.Commands.Posts;
using Cms.Core.DTOs.Post;
using Cms.Core.UseCases.Dtos;
using Cms.Core.UseCases.Interfaces;
using Cms.Api.Presenter.Post;

namespace Cms.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly IMediator mediator;
    //private readonly IEditPostUseCase editPostUseCase;
    private readonly PostApiPresenter<PostEditResponse> postApiPresenter;

    //private readonly IPostRepository<Cms.Data.Entities.Post, Cms.Core.Models.Post> postRepository;

    //public PostController(IPostRepository<Cms.Data.Entities.Post, Cms.Core.Models.Post> postRepository)
    //{
    //    this.postRepository = postRepository;
    //}

    public PostController(IMediator mediator
        //,IEditPostUseCase editPostUseCase,
        //PostApiPresenter<PostEditResponse> postApiPresenter
        )
    {
        this.mediator = mediator;
        //this.editPostUseCase = editPostUseCase;
        this.postApiPresenter = postApiPresenter;
    }

    [HttpGet("/getlatests/{count}")]
    public async Task<ActionResult<List<Post>>> Get(int count = 5)
    {
        var query = new GetLatestPostsQuery() { Count = count };
        var result = await mediator.Send(query);
        return Ok(result);
        //Ok(await postRepository.GetLatestPosts(count));
    }

    [HttpPost]
    public async Task<ActionResult<Post>> Post(PostCreateDto post) =>
     Ok(await mediator.Send(new PostAddCommand() { PostCreateDto = post }));


    [HttpPut]
    public async Task<ActionResult> Put(PostEditDto post)
    {
        var updatePost = new PostEditRequest()
        {
            Id=post.Id,
            CategoryId = post.CategoryId,
            Content = post.Content,
            Title = post.Title
        };
        //await editPostUseCase.HandleAsync(updatePost, postApiPresenter);
        return postApiPresenter.ContentResult;
    }
}
