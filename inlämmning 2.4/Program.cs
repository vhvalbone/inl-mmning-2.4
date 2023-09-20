using System;
namespace Uppgift_2._4
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("skriv in lönen för första arbetaren");
            double lön1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("skriv in lönen för andra arbetaren");
            double lön2=double.Parse(Console.ReadLine());

            Console.WriteLine("skriv in lönen för tredje arbetaren");
            double lön3=double.Parse(Console.ReadLine());

            double summa = (lön1 + lön2 + lön3)/3;

            Console.WriteLine("medellönen av allas löner är " + summa);
        }
    }
}
