using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequirementCreditManager : ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("Requirement Credit payment plan is calculated.");
        }
    }
}
