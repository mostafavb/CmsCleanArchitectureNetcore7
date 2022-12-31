using Cms.Core.UseCases.Dtos;
using Cms.Core.UseCases.Dtos.General;
using Cms.Core.UseCases.Interfaces;
using System.Net;

namespace Cms.Api.Presenter.Post;

public class PostApiPresenter<T> : IOutputPort<GenericResponse<T>>
{
    public JsonContentResult ContentResult;
    public PostApiPresenter()
    {
        ContentResult = new();
    }
    public void Handle(GenericResponse<T> response)
    {
        ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        ContentResult.Content = ContentResult.SerializeObject(response.Success ? (object)response.Data : (object)response.Errors);

    }
}
