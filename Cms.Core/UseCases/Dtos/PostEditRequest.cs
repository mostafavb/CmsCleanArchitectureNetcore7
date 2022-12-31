using Cms.Core.UseCases.Dtos.General;
using Cms.Core.UseCases.Interfaces;

namespace Cms.Core.UseCases.Dtos;
public class PostEditRequest : IUseCaseRequest<GenericResponse<PostEditResponse>>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Content { get; set; }
    public int CategoryId { get; set; }
}
