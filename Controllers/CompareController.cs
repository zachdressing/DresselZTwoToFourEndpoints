using DresselZTwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace DresselZTwoToFourEndpoints.Controllers;
[ApiController]
[Route("CompareEm")]
public class CompareController : Controller
{
    private readonly ICompareService _compareService;

    public CompareController(ICompareService compareService)
    {
        _compareService = compareService;
    }

    [HttpGet]
    [Route("Compare")]
    public string Compare(int x, int y){
        return _compareService.Compare(x, y);
    }
}
