namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus!");

            //peate kasutama if and else lause´id
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väiksem kui 18
            string sisend = Console.ReadLine();
            int vanus = int.Parse(sisend);


            if (vanus < 18)
            {
                Console.WriteLine("Oled liiga väike");

            }
            else
            {
                Console.WriteLine("Tere suur pois");

            }
        }
    }
}
