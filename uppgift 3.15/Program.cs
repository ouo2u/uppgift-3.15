using System;
namespace Uppgift_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många timmar tänker du hyra bilen för? svaren måste var helt antal timmar" + "80kr per timme ");
            int timmar= int.Parse(Console.ReadLine());
            {
                if (timmar > 950) ;
                Console.WriteLine("du kan tyvär inte hyra bilen för mer än 950 kr");
               
            }
            {  
              else if (timmar < 950)
                Console.WriteLine("priset är totalt" + timmar * 80 + "kr");
            }



        }
    }
}