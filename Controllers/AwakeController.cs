using Microsoft.AspNetCore.Mvc;
using DresselZTwoToFourEndpoints.Services;

namespace DresselZTwoToFourEndpoints.Controllers;
[ApiController]
[Route("AwakeEm")]
public class AwakeController : ControllerBase
{
    private readonly IAwakeService _awakeService;

    public AwakeController(IAwakeService awakeService)
    {
        _awakeService = awakeService;
    }


    [HttpGet]
    [Route("Awake")]
    public string awake(int hours, int mins, string name){
        return _awakeService.awake(hours, mins,name);
    }
}
