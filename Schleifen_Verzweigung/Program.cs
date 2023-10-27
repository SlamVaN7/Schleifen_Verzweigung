namespace Schleifen_Verzweigung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b; //Deklaration der Variablen von Typ Integer

            //Verzweigung
            Console.WriteLine("Auswahl:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");

            //Verzweigung mit if-else
            Console.Write("Auswahl = ");
            int auswahl;
            auswahl = Convert.ToInt32(Console.ReadLine());

            if (auswahl == 1)
            {
                Console.WriteLine("Addition von zwei ganzen Zahlen:");

                //Eingabe
                Console.WriteLine("Geben Die die Summanden ein:");
                Console.Write("a =");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b =");
                b = Convert.ToInt32(Console.ReadLine());

                //Verarbeitung
                int summe = a + b;

                //Ausgabe
                Console.WriteLine(a + " + " + b + " = " + summe);
            }
            else
            {
                Console.WriteLine("Subtraktion von zwei ganzen Zahlen:");

                //Eingabe
                Console.WriteLine("Geben Die die Minuend und Subtrahend ein:");
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());

                //Verarbeitung
                int differenz = a - b;

                //Ausgabe
                Console.WriteLine(a + " - " + b + " = " + differenz);
            }
            Console.ReadKey();
        }
    }
}