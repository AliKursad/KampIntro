using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Calculated");
        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
