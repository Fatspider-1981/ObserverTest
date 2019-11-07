using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    public class Manager : IEmployee
    {
        public double GetWages(double basicWages)
        {
            double totalWages = 1.5 * basicWages;
            Console.WriteLine("Manager's wages is : " + totalWages);
            return totalWages;
        }
    }
}
