using AverageCalculator;

public class AverageCalculatorTests 
{
    [Fact]
    public void Test1() 
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(5);
        Assert.Equal(1, calculator.count());
    }
}
 