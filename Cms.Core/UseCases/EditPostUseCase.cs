using Cms.Core.Interfaces.Repository;
using Cms.Core.Models;
using Cms.Core.UseCases.Dtos;
using Cms.Core.UseCases.Dtos.General;
using Cms.Core.UseCases.Interfaces;

namespace Cms.Core.UseCases;
public class EditPostUseCase : IEditPostUseCase
{
    private readonly IPostRepository postRepository;

    public EditPostUseCase(IPostRepository postRepository)
    {
        this.postRepository = postRepository;
    }
    public async Task HandleAsync(PostEditRequest message,
        IOutputPort<GenericResponse<PostEditResponse>> outputPort)
    {
        var post = new Post
        {
            Id = message.Id,
            CategoryId = message.CategoryId,
            Content = message.Content,
            Title = message.Title
        };

        await postRepository.Edit(post);

        outputPort.Handle(new GenericResponse<PostEditResponse>(data: new PostEditResponse { Id = post.Id }));
    }
}
