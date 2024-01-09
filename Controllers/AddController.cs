using Microsoft.AspNetCore.Mvc;
using DresselZTwoToFourEndpoints.Services;

namespace DresselZTwoToFourEndpoints.Controllers;
[ApiController]
[Route("AddEm")]
public class AddController : ControllerBase
{
    private readonly IAddService _addService;

    public AddController(IAddService addService)
    {
        _addService = addService;
    }

    [HttpGet]
    [Route("Add")]

    public string addItUp(int x, int y)
    {
        return _addService.addItUp(x, y);
    }

}
