namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sesesta enda nimi");

            //siin on muutuia nimega name 
            //mis on tüübiga string
            //loeb andmeid konsoolist
            //need muutuja name sisse
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tere," + name);

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.red;
                Console.WriteLine("Tere, tundmatu!");
                Console.beep();
                Console.sleep(99999);
            }
        }
    }
}


