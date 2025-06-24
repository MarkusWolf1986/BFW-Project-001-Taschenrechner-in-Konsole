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

            // While-Schleife, um das Programm mehrmals durchlaufen zu können
            while (repeetProgram == true)
            {
                // Die erste Zahl vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie die erste Zahle ein.");
                string inputNumber1 = Console.ReadLine();
                number1 = getNumber1(inputNumber1);

                // Den Rechenoperators vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie den Rechenoperator ein.");
                string inputCalculationOperator = Console.ReadLine();
                calculationOperator = getCulationOperator(inputCalculationOperator);

                // Die erste Zahl vom User entgegen nehmen
                Console.WriteLine("Bitte geben Sie die zweite Zahle ein.");
                string inputNumber2 = Console.ReadLine();
                number2 = getNumber2(inputNumber2);

                // Das Ergebnis ausrechnen



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

        // Methode, um die Zahl 1 entgegenzunehmen
        public static int getNumber1(string input)
        {
            return 5; // Erstmal fester Wert zum Testen

            //return number1;
        }
        // Methode, um die Zahl 2 entgegenzunehmen
        public static int getNumber2(string input)
        {
            return 3; // Erstmal fester Wert zum Testen

            //return number2;
        }
        // Methode, um die Zahl 2 entgegenzunehmen
        public static string getCulationOperator(string input)
        {
            return "+"; // Erstmal fester Wert zum Testen

            //return culationOperator;
        }
        // Methode, um das Programm beenden zu können
        public static string ProgramEnd()
        {

            return ;
        }
    }
}
