namespace Cms.Api.Controllers.Common;

public class Result
{
    public object Data { get; set; }
    public Status Status { get; set; }
    public string Message { get; set; }
}
