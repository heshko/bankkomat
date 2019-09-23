using System;
using static System.Console;
using System.Threading;
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInvaidCard = true;
            while (isInvaidCard)
            {
                Clear();
                Write("Card number: ");

                string cardNumber = ReadLine();

                Write("Pin code: ");

                string pinCode = ReadLine();

                if (cardNumber == "123456789" && pinCode == "1234")
                {
                    isInvaidCard = false;
                }
                else
                {
                    WriteLine("Invalid card");

                    Thread.Sleep(2000);
                }
            }

            WriteLine("1. withdraw");
            WriteLine("2. View details");
            WriteLine("3. Exit");
            ConsoleKeyInfo keyPressed = ReadKey();
            switch (keyPressed.Key)
            {
             
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                
                
            }
        }
    }
}
