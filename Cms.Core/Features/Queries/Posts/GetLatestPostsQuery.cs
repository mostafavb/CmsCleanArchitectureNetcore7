using Cms.Core.Models;
using MediatR;

namespace Cms.Core.Features.Queries.Posts;
public class GetLatestPostsQuery : IRequest<List<Post>>
{
    public int Count { get; set; }
}
