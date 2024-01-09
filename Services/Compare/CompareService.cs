namespace DresselZTwoToFourEndpoints.Services;

public class CompareService : ICompareService
{
    public string Compare(int x, int y)
    {
        if (x > y)
        {
            return $"{x} is greater than {y}.";
        }
        else if (y > x)
        {
            return $"{y} is greater than {x}.";
        }
        else
        {
            return $"{x} and {y} are equal.";
        }
    }
}