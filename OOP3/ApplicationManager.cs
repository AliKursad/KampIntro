using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Application(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        
        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
