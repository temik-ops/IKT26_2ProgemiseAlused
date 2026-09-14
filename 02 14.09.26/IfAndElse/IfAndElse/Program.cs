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
            
            //if ja else kontrollib, kas muutuja 
            //name  on tühi või mitte
            //kui muutuja name on tühi siis väljastab konsoolile 
            //teksti "tere tundmatu" ja teeb 4 piiksu

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
                Console.sleep(1000);
                Console.beep();
                Console.sleep(1000);
                Console.beep();
                Console.sleep(1000);
                Console.beep();
                Console.sleep(1000);
            }
        }
    }
}


