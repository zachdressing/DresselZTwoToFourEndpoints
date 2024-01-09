namespace DresselZTwoToFourEndpoints.Services;

public class AwakeService : IAwakeService
{
    public string awake(int time, string name)
    {
        if (time <= 12 && time > 0)
        {
            return $"{name} woke up at {time} AM.";
        }
        else
        {
            return "Incorrect time. Try Again.";
        }
    }
}   