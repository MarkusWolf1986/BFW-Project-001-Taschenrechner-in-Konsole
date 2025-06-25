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
                Console.WriteLine("Bitte geben Sie die erste Zahle ein. \n");
                string inputNumber1 = Console.ReadLine();
                number1 = getNumber1(inputNumber1);

                // Den Rechenoperators vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie den Rechenoperator ein. \n");
                string inputCalculationOperator = Console.ReadLine();
                calculationOperator = getCulationOperator(inputCalculationOperator);

                // Die zweite Zahl vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie die zweite Zahle ein. \n");
                string inputNumber2 = Console.ReadLine();
                number2 = getNumber2(inputNumber2);

                // Das Ergebnis ausrechnen
                if (calculationOperator == "+")
                {
                    result = number1 + number2;
                }
                else if (calculationOperator == "-")
                {
                    result = number1 - number2;
                }
                else if (calculationOperator == "*")
                {
                    result = number1 * number2;
                }
                else (calculationOperator == "/")
                {
                    result = number1 / number2;
                }

                // Dem User das Ergebniss ausgeben
                Console.WriteLine("Das Ergebnis lautet: " + result + ".");

                // Dem User fragen, ob er noch eine Berechnung durchführen will
                Console.WriteLine("Wollen Sie noch eine Berechnung durchführen?");
                string inputProgramEnd = Console.ReadLine();
                XesOrNo = ProgramEnd(inputXesOrNo);






                //if ( )
                //{
                //    repeetProgram = true;
                //}
                //else if ()
                //{
                //    repeetProgram = false;
                //    Console.WriteLine("Das Programm wird beendet.");
                //}
                //else if ()
                //{
                //    Console.WriteLine("Bitte nur mit J oder N antworten.");
                //}


                // Nur zu Entwicklungszwecken:
                repeetProgram = false;
            }
        }

        // Statische Methoden für die Main

        // Zahl 1 entgegenzunehmen
        public static int getNumber1(string input)
        {
            return 5; // Erstmal fester Wert zum Testen

            //return number1;
        }
        // Zahl 2 entgegenzunehmen
        public static int getNumber2(string input)
        {
            return 3; // Erstmal fester Wert zum Testen

            //return number2;
        }
        // Rechenoperator entgegenzunehmen
        public static string getCulationOperator(string input)
        {
            if (input == "+" || input == "-" || input == "*" || input == "/")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Ungültiger Operator. \n" +
                    "+, -, * und / stehen zuer Auswahl.");
            }
        }
        // Programm beenden
        public static string ProgramEnd()
        {

            return;
        }
    }
}
