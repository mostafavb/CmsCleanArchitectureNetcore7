using Cms.Core.UseCases.Dtos;
using Cms.Core.UseCases.Dtos.General;

namespace Cms.Core.UseCases.Interfaces;
public interface IEditPostUseCase : IUseCaseRequestHandler<PostEditRequest,GenericResponse<PostEditResponse>>
{

}
