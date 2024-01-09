namespace DresselZTwoToFourEndpoints.Services;

public class AwakeService : IAwakeService
{
    public string awake(int hours, int mins, string name)
    {
        return $"{name} woke up at {hours}:{mins}.";
    }
}