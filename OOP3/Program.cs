using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(ICreditManager)*/
            RequirementCreditManager requirementCreditManager = new RequirementCreditManager();
            ICreditManager dwellingCreditManager = new DwellingCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            /* if you write;
            *ILoggerService databaseLoggerService = new DatabaseLoggerService();
            *ILoggerService fileLoggerService = new FileLoggerService();
            *instead of ....,new DatabaseLoggerService -> (databaseLoggerService)*/

            RequestManager requestManager = new RequestManager();
            //new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()}
            requestManager.Request(vehicleCreditManager, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() { vehicleCreditManager, dwellingCreditManager };

            //requestManager.CreditPreinforming(credits);
        }
    }
}
