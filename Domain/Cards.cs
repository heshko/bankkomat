using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Domain
{
    class Cards
    {
        string  cardNumber;

        string pinCode;

        public Cards(string cardNumber, string pinCode)
        {
            this.cardNumber = cardNumber;

            this.pinCode = pinCode;
        }
        //public string GetCardNumber()
        //{
        //    return cardNumber;
        //}
        public string CardNumber
        {
            get { return cardNumber; }
          //  set { cardNumber = value; }
        }
        //public string GetPinCord()
        //{
        //    return pinCode;
        //}
        public string PinCode
        {
            get { return pinCode; }
            set {
                if (value == pinCode)
                {
                    throw new ArgumentException("new pincode cannot be same as previous");
                }

                pinCode = value; }
        }

        public void setPinCode(string value)
        {
            if (value == pinCode)
            {
                throw new ArgumentException("new pincode cannot be same as previous");
            }
        }
    }
}
