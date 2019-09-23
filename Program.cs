using System;
using static System.Console;
using System.Threading;
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInvalidCard = true;
           
            while (true)
            {
                Clear();
                Write("Card number: ");

                string cardNumber = ReadLine();

                Write("Pin code: ");

                string pinCode = ReadLine();

                Clear();

                if (cardNumber == "123456789" && pinCode == "1234")
                {
                isInvalidCard = false;
                    while (!isInvalidCard)
                    {
                       
                        WriteLine("1. withdraw");
                        WriteLine("2. View details");
                        WriteLine("3. Abort");
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
                else
                {
                    WriteLine("Invalid card");

                    Thread.Sleep(2000);
                }
            }
          
          
        }
    }
}
