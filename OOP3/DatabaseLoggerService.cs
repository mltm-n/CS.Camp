using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Logging()
        {
            Console.WriteLine("Logged to the database.");
        }
    }
}
