using System;
 
namespace AverageCalculator;
    /// <summary>
    /// Die Klasse AverageCalculator dient zur Speicherung von Zahlenwerte
    /// und zur Berechnung des Durchschnitts
    /// </summary>
    public class AverageCalculator
    {
        /// <summary>
        /// Array zur Speicherung aller hinzugefügten Zahlenwerte
        /// </summary>
        private double[] values;
 
        /// <summary>
        /// Konstruktor der Klasse.
        /// Initialisiert das Werte-Array mit der Länge 0.
        /// </summary>
        public AverageCalculator()
        {
            values = new double[0];
        }
 
        /// <summary>
        /// Fügt einen einzelnen Zahlenwert zum Array hinzu.
        /// </summary>
        /// <param name="value">Der hinzuzufügende Wert</param>
        public void add(double value)
        {
            double[] newArray = new double[values.Length + 1];
 
            for (int count = 0; count < values.Length; count++)
            {
                newArray[count] = values[count];
            }
 
            newArray[values.Length] = value;
            values = newArray;
        }
 
        /// <summary>
        /// Fügt mehrere Zahlenwerte auf einmal hinzu.
        /// </summary>
        /// <param name="newValues">Array mit neuen Werten</param>
        public void add(double[] newValues)
        {
            if (newValues == null || newValues.Length == 0)
            {
                return;
            }
 
            double[] newArray = new double[values.Length + newValues.Length];
 
            for (int count = 0; count < values.Length; count++)
            {
                newArray[count] = values[count];
            }
 
            for (int count = 0; count < newValues.Length; count++)
            {
                newArray[values.Length + count] = newValues[count];
            }
 
            values = newArray;
        }
 
        /// <summary>
        /// Berechnet den Durchschnitt aller gespeicherten Werte.
        /// </summary>
        /// <returns>Durchschnitt oder 0, falls keine Werte vorhanden sind</returns>
        public double getAverage()
        {
            if (values.Length == 0)
            {
                return 0;
            }
 
            double sum = 0;
 
            for (int count = 0; count < values.Length; count++)
            {
                sum += values[count];
            }
 
            return sum / values.Length;
        }
 
        /// <summary>
        /// Gibt eine Kopie aller gespeicherten Werte zurück.
        /// </summary>
        /// <returns>Array mit allen Werten</returns>
        public double[] getElements()
        {
            double[] result = new double[values.Length];
 
            for (int count = 0; count < values.Length; count++)
            {
                result[count] = values[count];
            }
 
            return result;
        }
 
        /// <summary>
        /// Gibt die Anzahl der gespeicherten Werte zurück.
        /// </summary>
        /// <returns>Anzahl der Elemente</returns>
        public int count()
        {
            return values.Length;
        }
}