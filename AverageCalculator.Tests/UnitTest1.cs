using AverageCalculator;

namespace AverageCalculator.Tests;

/// <summary>
/// Unit-Tests für die Klasse AverageCalculator.
/// </summary>
public class AverageCalculatorTests
{
    /// <summary>
    /// Testet, ob das Hinzufügen eines einzelnen Wertes
    /// die Anzahl der gespeicherten Werte auf 1 erhöht.
    /// </summary>
    [Fact]
    public void Add_SingleValue_IncreasesCount()
    {
        var calculator = new AverageCalculator();
        calculator.add(5);
        Assert.Equal(1, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob der Durchschnitt bei genau einem Wert
    /// diesem Wert entspricht.
    /// </summary>
    [Fact]
    public void Add_SingleValue_AverageIsValue()
    {
        var calculator = new AverageCalculator();
        calculator.add(10);
        Assert.Equal(10, calculator.getAverage());
    }
 
    /// <summary>
    /// Testet, ob mehrere einzelne add-Aufrufe
    /// korrekt gezählt werden.
    /// </summary>
    [Fact]
    public void Add_MultipleSingleAdds_CountCorrect()
    {
        var calculator = new AverageCalculator();
        calculator.add(5);
        calculator.add(15);
        Assert.Equal(2, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob beim Hinzufügen eines Arrays
    /// alle Werte gespeichert werden.
    /// </summary>
    [Fact]
    public void Add_Array_AddsAllValues()
    {
        var calculator = new AverageCalculator();
        double[] values = [5, 10, 15];
        calculator.add(values);
        Assert.Equal(3, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob ein leeres Array
    /// keine Werte hinzufügt.
    /// </summary>
    [Fact]
    public void Add_EmptyArray_DoesNothing()
    {
        var calculator = new AverageCalculator();
        calculator.add([]);
        Assert.Equal(0, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob ein null-Array
    /// keine Auswirkungen hat.
    /// </summary>
    [Fact]
    public void Add_NullArray_DoesNothing()
    {
        var calculator = new AverageCalculator();
        calculator.add(null);
        Assert.Equal(0, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob der Durchschnitt ohne Werte
    /// 0 zurückgibt.
    /// </summary>
    [Fact]
    public void GetAverage_NoValues_ReturnsZero()
    {
        var calculator = new AverageCalculator();
        Assert.Equal(0, calculator.getAverage());
    }
 
    /// <summary>
    /// Testet, ob der Durchschnitt bei einem Wert
    /// korrekt berechnet wird.
    /// </summary>
    [Fact]
    public void GetAverage_OneValue_ReturnsValue()
    {
        var calculator = new AverageCalculator();
        calculator.add(8);
        Assert.Equal(8, calculator.getAverage());
    }
 
    /// <summary>
    /// Testet, ob der Durchschnitt bei mehreren Werten
    /// korrekt berechnet wird.
    /// </summary>
    [Fact]
    public void GetAverage_MultipleValues_ReturnsCorrectAverage()
    {
        var calculator = new AverageCalculator();
        calculator.add([10, 20, 30]);
        Assert.Equal(20, calculator.getAverage());
    }
 
    /// <summary>
    /// Testet, ob ohne gespeicherte Werte
    /// ein leeres Array zurückgegeben wird.
    /// </summary>
    [Fact]
    public void GetElements_NoValues_ReturnsEmptyArray()
    {
        var calculator = new AverageCalculator();
        Assert.Empty(calculator.getElements());
    }
 
    /// <summary>
    /// Testet, ob alle gespeicherten Werte
    /// zurückgegeben werden.
    /// </summary>
    [Fact]
    public void GetElements_ReturnsAllValues()
    {
        var calculator = new AverageCalculator();
        calculator.add([1, 2, 3]);
        double[] elements = calculator.getElements();
        Assert.Equal(3, elements.Length);
    }
 
    /// <summary>
    /// Testet, ob getElements eine Kopie zurückgibt
    /// und interne Werte nicht verändert werden können.
    /// </summary>
    [Fact]
    public void GetElements_ReturnsCopy_NotOriginalArray()
    {
        var calculator = new AverageCalculator();
        calculator.add(5);
        double[] elements = calculator.getElements();
        elements[0] = 100;
        Assert.Equal(5, calculator.getAverage());
    }
 
    /// <summary>
    /// Testet, ob count ohne Werte
    /// 0 zurückgibt.
    /// </summary>
    [Fact]
    public void Count_NoValues_ReturnsZero()
    {
        var calculator = new AverageCalculator();
        Assert.Equal(0, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob count bei einem Wert
    /// 1 zurückgibt.
    /// </summary>
    [Fact]
    public void Count_OneValue_ReturnsOne()
    {
        var calculator = new AverageCalculator();
        calculator.add(3);
        Assert.Equal(1, calculator.count());
    }
 
    /// <summary>
    /// Testet, ob count bei mehreren Werten
    /// korrekt ist.
    /// </summary>
    [Fact]
    public void Count_MultipleValues_ReturnsCorrectCount()
    {
        var calculator = new AverageCalculator();
        calculator.add([1, 2, 3, 4]);
        Assert.Equal(4, calculator.count());
    }
}