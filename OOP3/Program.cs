using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            ICreditManager transportCreditManager = new TransportCreditManager();
           //transportCreditManager.Calculate();

            ICreditManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Application(personalFinanceCreditManager);
            applicationManager.Application(transportCreditManager, fileLoggerService);
            applicationManager.Application(mortgageManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, transportCreditManager, mortgageManager};
          //applicationManager.CreditInfo(credits);
            
        }
    }
}
