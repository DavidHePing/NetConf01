using Microsoft.AspNetCore.Mvc;

namespace NetConf01.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Get";
    }
    
    [HttpPost]
    public string Post()
    {
        return "Post";
    }

    [HttpPatch]
    public string Patch()
    {
        return "Patch";
    }

    [HttpDelete]
    public string Delete()
    {
        return "Delete";
    }
}