using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequestManager
    {
        //method injection
        // List<ILoggerService> loggerService
        public void Request(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculation();
            loggerService.Logging();
            /* foreach (var loggerService in loggerServices)
             {
                loggerService.Logging();
             } 
            */
        }
        public void CreditPreinforming(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculation();
            }

        }
    }
}
