
namespace Cms.Core.UseCases.Dtos.General;
public class GenericResponse<T> : UseCaseResponseMessage
{
    public T Data { get; }
    public IEnumerable<Error> Errors { get; }

    public GenericResponse(IEnumerable<Error> errors, bool success = false, string message = "") : base(success, message)
    {
        Errors = errors;
    }
    public GenericResponse(T data, bool success = false, string message = "") : base(success, message)
    {
        Data = data;
    }

    public GenericResponse(bool success = false, string message = "") : base(success, message)
    {

    }
}
