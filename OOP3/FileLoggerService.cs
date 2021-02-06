using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Logging()
        {
            Console.WriteLine("Logged to the file.");
        }
    }
}
