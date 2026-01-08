using AverageCalculator;
 
namespace Program00;
 
public class Program00
{
    public static int Main()
    {
        AverageCalculator.AverageCalculator calculator = new();
 
        double[] numbers = [5, 10, 15, 20];
 
        calculator.add(numbers);
        calculator.add(67);
 
        double[] elements = calculator.getElements();
 
        Console.WriteLine("Gespeicherte Werte:");
        for (int count = 0; count < elements.Length; count++)
        {
            Console.WriteLine(elements[count]);
        }
 
        Console.WriteLine("Anzahl: " + calculator.count());
        Console.WriteLine("Durchschnitt: " + calculator.getAverage());
 
        return 0;
    }
}