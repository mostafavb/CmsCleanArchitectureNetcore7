using Cms.Core.DTOs.Post;
using Cms.Core.Models;
using MediatR;

namespace Cms.Core.Features.Commands.Posts;
public class PostAddCommand : IRequest<Post>
{
    public PostCreateDto PostCreateDto{ get; set; }
}