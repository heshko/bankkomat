using System;
using static System.Console;
using System.Threading;
using ATM.Domain;
namespace ATM
{
    class Program
    {
       static Cards[] cards = new Cards[100];
        static void Main(string[] args)
        {
            bool isValidCard = false;
           

            cards[0] = new Cards(cardNumber:"123", pinCode:"123");
            cards[1] = new Cards(cardNumber:"1234213", pinCode:"123453123");

            //Cards card = new Cards("12345","12345");
           
            while (true)
            {
                Clear();
                Write("Card number: ");

                string cardNumber = ReadLine();

                Write("Pin code: ");

                string pinCode = ReadLine();

                Clear();

                Cards vaildCard = FindValidCard(cardNumber,pinCode);

                for(int x = 0; x < cards.Length; x++)
                {
                    if (cards[x] == null) continue;
                     if ( cards[x].CardNumber==cardNumber || cards[x].PinCode == pinCode)
                    {
                        vaildCard = cards[x];
                        break;
                    }
                }


                if (vaildCard!=null)
                {
                    isValidCard = true;
                  
                }
                else
                {
                    WriteLine("Invalid card");

                    Thread.Sleep(2000);
                }

                while (isValidCard)
                {

                    WriteLine("1. withdraw");
                    WriteLine("2. View details");
                    WriteLine("3. Abort");
                    ConsoleKeyInfo keyPressed = ReadKey(true);
                    switch (keyPressed.Key)
                    {

                        case ConsoleKey.D3:
                            isValidCard = false;
                            break;
                    }



                }
            }
          
          
        }
        static Cards FindValidCard(string cardNumber, string pinCode)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == null) continue;
                if (cards[i].CardNumber == cardNumber && cards[i].PinCode == pinCode)
                {
                    return  cards[i];
                 
                }
            }
            return null;
        }
}
}
