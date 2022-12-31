using Cms.Core.Features.Queries.Posts;
using Cms.Core.Interfaces.Repository;
using Cms.Core.Models;
using MediatR;

namespace Cms.Core.Features.Handlers.Posts;
public class GetLatestPostsHandler : IRequestHandler<GetLatestPostsQuery, List<Post>>
{
    private readonly IPostRepository postRepository;

    public GetLatestPostsHandler(IPostRepository postRepository)
    {
        this.postRepository = postRepository;
    }
    public async Task<List<Post>> Handle(GetLatestPostsQuery request, CancellationToken cancellationToken)
    {
        return await postRepository.GetLatestPosts(request.Count);
    }
}
