using System.Security.Cryptography.X509Certificates;

namespace BFW_Project_001_Taschenrechner_in_Konsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Globale Variablen

            // Boolescher Wert für den Schleifendurchlauf
            bool repeetProgram = true;
            // Die beiden Zahlen mit denen wir rechen
            double number1 = 0;
            double number2 = 0;
            // Die Variable für das Ergebnis
            double result = 0;
            // Der Rechenoperator
            string calculationOperator = null;


            // Der eigentliche Programmablauf in einer While-Schleife
            while (repeetProgram == true)
            {
                // Die erste Zahl vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie die erste Zahle ein. \n" +
                    "ENTER zum Bestätigen");
                string inputNumber1 = Console.ReadLine();
                number1 = getNumber1(inputNumber1);

                // Den Rechenoperators vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie den Rechenoperator ein. \n" +
                    "ENTER zum Bestätigen");
                string inputCalculationOperator = Console.ReadLine();
                calculationOperator = getCulationOperator(inputCalculationOperator);

                // Die zweite Zahl vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie die zweite Zahle ein. \n" +
                    "ENTER zum Bestätigen");
                string inputNumber2 = Console.ReadLine();
                number2 = getNumber2(inputNumber2);

                // Das Ergebnis ausrechnen
                switch (calculationOperator)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("Ungültiger Operator!");
                        break;
                }

                // Dem User das Ergebniss ausgeben
                Console.WriteLine("Das Ergebnis lautet: " + result + ".");

                // Dem User fragen, ob er noch eine Berechnung durchführen will
                Console.WriteLine("Wollen Sie noch eine Berechnung durchführen? \n j oder n");


                string inputProgramEnd = null;
                while (inputProgramEnd != "j" && inputProgramEnd != "n")
                {
                    inputProgramEnd = Console.ReadLine();
                    if (inputProgramEnd == "n")
                    {
                        Console.WriteLine("Das Programm wird beendet.");
                        repeetProgram = false;
                    }
                    else if (inputProgramEnd == "j")
                    {
                        repeetProgram = true;
                    }
                    else
                    {
                        Console.WriteLine("Bitte nur 'j' oder 'n' eingeben!");
                    }
                }
            }
        }
        

        // Statische Methoden für die Main

            // Zahl 1 entgegenzunehmen
        public static double getNumber1(string input)
        {
            double number1 = Convert.ToDouble(input);
            return number1;
        }
        // Zahl 2 entgegenzunehmen
        public static double getNumber2(string input)
        {
            double number2 = Convert.ToDouble(input);
            return number2;
        }
        // Rechenoperator entgegenzunehmen
        public static string getCulationOperator(string input)
        {
            do
            {
                if (input == "+" || input == "-" || input == "*" || input == "/")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Ungültiger Operator. \n" +
                        "+, -, * und / stehen zur Auswahl.");
                    Console.WriteLine("Bitte geben Sie einen gültigen Rechenoperator ein:");
                    input = Console.ReadLine();
                }

            } while (true);  // Endlosschleife, weil return die Methode verlässt
        }
    }
}
