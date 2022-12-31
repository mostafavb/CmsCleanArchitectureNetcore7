namespace Cms.Core.UseCases.Dtos.General;
public class UseCaseResponseMessage
{
    public UseCaseResponseMessage(bool success = false, string? message = null)
    {
        Success = success;
        Message = message;
    }

    public bool Success { get; }
    public string? Message { get; }
}
