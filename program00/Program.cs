using AverageCalculator;
 
namespace Program00;
 
    /// <summary>
    /// Program welches die AverageCalculator Funktion verwendet
    /// </summary>
public class Program00
{
    /// <summary>
    /// AverageCalculator wird aufgerufen, Werte werden in einem Array gespeichert,
    /// Funktion AverageCalculator wird auf Array angewendet.
    /// Anzahl der gespeicherten Werte und Durchschnitt der gespeicherten Werte wird ausgegeben.
    /// </summary>
    /// <returns>
    /// Gibt den Wert 0 zurück, wenn das Programm ohne Fehler beendet wurde.
    /// </returns>
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