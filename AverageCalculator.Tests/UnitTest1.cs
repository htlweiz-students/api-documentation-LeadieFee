using AverageCalculator;

namespace AverageCalculator.Tests;
public class AverageCalculatorTests
{
    [Fact]
    public void Add_SingleValue_IncreasesCount()
    {
        var calculator = new AverageCalculator();
        calculator.add(5);
        Assert.Equal(1, calculator.count());
    }
 
    [Fact]
    public void Add_SingleValue_AverageIsValue()
    {
        var calculator = new AverageCalculator();
        calculator.add(10);
        Assert.Equal(10, calculator.getAverage());
    }
 
    [Fact]
    public void Add_MultipleSingleAdds_CountCorrect()
    {
        var calculator = new AverageCalculator();
        calculator.add(5);
        calculator.add(15);
        Assert.Equal(2, calculator.count());
    }
 
    [Fact]
    public void Add_Array_AddsAllValues()
    {
        var calculator = new AverageCalculator();
        double[] values = [ 5, 10, 15 ];
        calculator.add(values);
        Assert.Equal(3, calculator.count());
    }
 
    [Fact]
    public void Add_EmptyArray_DoesNothing()
    {
        var calculator = new AverageCalculator();
        calculator.add([]);
        Assert.Equal(0, calculator.count());
    }
 
    [Fact]
    public void Add_NullArray_DoesNothing()
    {
        var calculator = new AverageCalculator();
        calculator.add(null);
        Assert.Equal(0, calculator.count());
    }
 
    [Fact]
    public void GetAverage_NoValues_ReturnsZero()
    {
        var calculator = new AverageCalculator();
        Assert.Equal(0, calculator.getAverage());
    }
 
    [Fact]
    public void GetAverage_OneValue_ReturnsValue()
    {
        var calculator = new AverageCalculator();
        calculator.add(8);
        Assert.Equal(8, calculator.getAverage());
    }
 
    [Fact]
    public void GetAverage_MultipleValues_ReturnsCorrectAverage()
    {
        var calculator = new AverageCalculator();
        calculator.add([10, 20, 30]);
        Assert.Equal(20, calculator.getAverage());
    }
 
    [Fact]
    public void GetElements_NoValues_ReturnsEmptyArray()
    {
        var calculator = new AverageCalculator();
        Assert.Empty(calculator.getElements());
    }
 
    [Fact]
    public void GetElements_ReturnsAllValues()
    {
        var calculator = new AverageCalculator();
        calculator.add([ 1, 2, 3 ]);
        double[] elements = calculator.getElements();
        Assert.Equal(3, elements.Length);
    }
 
    [Fact]
    public void GetElements_ReturnsCopy_NotOriginalArray()
    {
        var calculator = new AverageCalculator();
        calculator.add(5);
        double[] elements = calculator.getElements();
        elements[0] = 100;
        Assert.Equal(5, calculator.getAverage());
    }
 
    [Fact]
    public void Count_NoValues_ReturnsZero()
    {
        var calculator = new AverageCalculator();
        Assert.Equal(0, calculator.count());
    }
 
    [Fact]
    public void Count_OneValue_ReturnsOne()
    {
        var calculator = new AverageCalculator();
        calculator.add(3);
        Assert.Equal(1, calculator.count());
    }
 
    [Fact]
    public void Count_MultipleValues_ReturnsCorrectCount()
    {
        var calculator = new AverageCalculator();
        calculator.add([ 1, 2, 3, 4 ]);
        Assert.Equal(4, calculator.count());
    }
}