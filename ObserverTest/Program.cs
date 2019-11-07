using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{

    public delegate double Observerable(double observableWages);

    class Program
    {
        static void Main(string[] args)
        {
            WageManager wageManager = new WageManager();

            //加入WageManager观察者
            IEmployee wagemanager = new WageManager();
            Observerable ObserverableWageManager = new Observerable(wagemanager.GetWages);
            wageManager.Attach(ObserverableWageManager);


            //加入Manager观察者
            IEmployee manager = new Manager();
            Observerable ObserverableManager = new Observerable(manager.GetWages);
            wageManager.Attach(ObserverableManager);

            //加入Workder观察者
            IEmployee worker = new Worker();
            Observerable ObserverableWorker = new Observerable(worker.GetWages);
            wageManager.Attach(ObserverableWorker);

            //同时加入底薪3000元，分别进行计算

            wageManager.Calculate(3000);
            Console.ReadKey();
        }
    }
}

