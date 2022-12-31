using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cms.Api.Presenter;

public class JsonContentResult : ContentResult
{
    public JsonContentResult()
    {
        ContentType = "application/json";
    }
    

    public string SerializeObject(object data) =>
        JsonConvert.SerializeObject(data,
            Newtonsoft.Json.Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }
            );
}
