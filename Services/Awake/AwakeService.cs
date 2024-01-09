namespace DresselZTwoToFourEndpoints.Services;

public class AwakeService : IAwakeService
{
    public string awake(int time, string name)
    {
        return $"{name} woke up at {time} AM.";
    }
}