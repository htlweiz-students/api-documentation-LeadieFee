using AverageCalculator;

namespace program00;
public class program00 {
    public static int Main() {
        AverageCalculator.AverageCalculator calculator = new AverageCalculator.AverageCalculator();

        double[] numbers = {28, 19, 8, 10};

        calculator.add(numbers);
        calculator.add(5);
        calculator.add(10);
        calculator.add(15);

        double[] elements = calculator.getElements();

        Console.WriteLine("Gespeicherte Werte: ");
        for(int count = 0; count < elements.Length; count++) {
            Console.WriteLine(elements[count]);
        }

        Console.WriteLine("Anzahl: " + calculator.count());
        Console.WriteLine("Durchschnitt: " + calculator.getAverage());

        return 0;
    }
}
