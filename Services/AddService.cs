namespace DresselZTwoToFourEndpoints.Services;

public class AddService : IAddService
{
    public string addItUp(int x, int y)
    {
        return $"The sum of {x} and {y} is {x + y}";
    }
}