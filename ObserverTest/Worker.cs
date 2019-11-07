using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    public class Worker : IEmployee
    {
        public double GetWages(double basicWages)
        {
            double totalWages = 1.2 * basicWages;
            Console.WriteLine("Normal Workder's wages is : " + totalWages);
            return totalWages;
        }
    }
}

