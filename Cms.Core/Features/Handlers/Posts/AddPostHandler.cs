using Cms.Core.DTOs.Post;
using Cms.Core.Features.Commands.Posts;
using Cms.Core.Interfaces.Repository;
using Cms.Core.Models;
using MediatR;

namespace Cms.Core.Features.Handlers.Posts;
public class AddPostHandler : IRequestHandler<PostAddCommand, Post>
{
    private readonly IPostRepository postRepository;

    public AddPostHandler(IPostRepository postRepository)
    {
        this.postRepository = postRepository;
    }
    public async Task<Post> Handle(PostAddCommand request, CancellationToken cancellationToken)
    {
        return await postRepository.Add(request.PostCreateDto);
    }
}
