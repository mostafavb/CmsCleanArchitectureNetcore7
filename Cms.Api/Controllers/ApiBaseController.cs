using Cms.Api.Controllers.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers;

public class ApiBaseController : ControllerBase
{
    public ActionResult ApiOk(string message = "", object data = null)
    {
        return Ok(new Result()
        {
            Message = message,
            Data = data,
            Status = Status.Success
        });
    }

    public ActionResult ApiBadRequest(string message = "", object data = null)
    {
        return BadRequest(new Result()
        {
            Message = message,
            Data = data,
            Status = Status.Fauild
        });
    }
}
