using System.Security.Cryptography.X509Certificates;

namespace BFW_Project_001_Taschenrechner_in_Konsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Globale Variablen
            bool repeetProgram = true;

            // START des Programmablaufes

            // While-Schleife, um das Programm mehrmals durchlaufen zu können
            while ( repeetProgram = false )
            {
                // Variable für den Programmablauf

                // Die beiden Zahlen mit denen wir rechen
                double number1 = 0;
                double number2 = 0;
                // Die Variable für das Ergebnis
                double result = 0;
                // Der Rechenoperator
                string calculationOperator = null;


                // Der Programmablauf

                // Den User zu Eingabe der ersten Zahl auffordern
                Console.WriteLine("Bitte geben Sie die erste Zahle ein.");
                string inputNumber1 = Console.ReadLine();
                number1 = getNumber1(inputNumber1);

                // Den User zu Eingabe des Rechenoperators auffordern
                Console.WriteLine("Bitte geben Sie den Rechenoperator ein.");
                string inputCalculationOperator = Console.ReadLine();
                calculationOperator = getalCulationOperator(inputCalculationOperator);

                // Den User zu Eingabe der zweiten Zahl auffordern
                Console.WriteLine("Bitte geben Sie die zweite Zahle ein.");
                string inputNumber2 = Console.ReadLine();
                number2 = getNumber2(inputNumber2);


                // Funktion, um das Ergebnis zu berechnen


                // Dem User das Ergebniss ausgeben
                Console.WriteLine("Das Ergebnis lautet: " + result);

                // Dem User das Ergebniss ausgeben
                Console.WriteLine("Wollen Sie noch eine Berechnung durchführen?");
                Console.ReadLine();



                if ( )
                {
                    repeetProgram = true;
                }
                else if ()
                {
                    repeetProgram = false;
                    Console.WriteLine("Das Programm wird beendet.");
                }
                else if ()
                {
                    Console.WriteLine("Bitte nur mit J oder N antworten.");
                }



                // Nur zu Entwicklungszwecken:
                repeetProgram = false;

            }
            // ENDE des Programmablaufes

            // Statische Methoden für die Main

            // Methode, um die Zahl 1 entgegenzunehmen
        public static int getNumber1()
        {

            return number1;
        }
        // Methode, um die Zahl 2 entgegenzunehmen
        public static int Number2()
        {

            return number2;
        }
        // Methode, um die Zahl 2 entgegenzunehmen
        public static string getalCulationOperator()
        {

            return culationOperator;
        }

    }
}
