using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the restocking tool!");


        {
            int soda = 100;
            Console.WriteLine("How many sodas were sold today? There were " + soda);
            int sodasold = int.Parse(Console.ReadLine());
            int sodanow = soda - sodasold;
            if (sodanow >= 0) {
                Console.WriteLine("There are now " + sodanow);
            } else 
            {
                Console.WriteLine("Whoops! Thats not possible. There are still " + soda);
            }
            int chips = 40;
            Console.WriteLine("How many chips were sold today? There were " + chips);
            int chipssold = int.Parse(Console.ReadLine());
            int chipsnow = chips - chipssold;
            if (chipsnow >= 0) {
                    Console.WriteLine("There are now " + chipsnow);
            } else
              {
                 Console.WriteLine("Whoops! Thats not possible. There are still" + chips);
              }
            
            
            int candy = 60;
            Console.WriteLine("How much candy was sold today? There was " + candy);
            int candysold = int.Parse(Console.ReadLine());
            int candynow = candy - candysold;
            if (candynow >= 0)
            {
                    Console.WriteLine("There are now " + candynow);
            } else
                {
                    Console.WriteLine("Whoops! Thats not possible. There are still" + candy);
                }
            
            Console.WriteLine("Thank you for entering the sales.");
            int sodalow = 40;
            int candylow = 30;
            int chipslow = 20;
            Console.WriteLine ("These items need to be restocked");
            if (sodanow >= 0 && sodanow <= sodalow)
                {
                    Console.WriteLine("Soda needs to be restocked");
                }
            if (chipsnow >= 0 && chipsnow <= chipslow)
            {
                Console.WriteLine("Chips need to be restocked");
            }
            if (candynow >= 0 && candynow <= candylow)
            {
                Console.WriteLine("Candy needs to be restocked");
            }
        }
    }
}