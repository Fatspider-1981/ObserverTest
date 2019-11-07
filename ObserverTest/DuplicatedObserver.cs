//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObserverTest1

//{
//    class DuplicatedObserver
//    {
//        static void Main(string[] args)
//        {
//            WageManager wageManager = new WageManager();

//            Manager newManager = new Manager();
//            ObservableTest ObservableManager = new ObservableTest(newManager.GetWage);
//            wageManager.Add(ObservableManager);
//            Worker newWorker = new Worker();
//            ObservableTest ObservableWorker = new ObservableTest(newWorker.GetWage);
//            wageManager.Add(ObservableWorker);

//            wageManager.Excute(3000);
//            Console.ReadKey();
//        }


//    }



//}

//public delegate double ObservableTest(double basicWage);
//class WageManager
//{
//    private ObservableTest _observableList;

//    public void Add(ObservableTest newObserver)
//    {
//        _observableList += newObserver;
//    }

//    public void Remove(ObservableTest newObserver)
//    {
//        _observableList -= newObserver;
//    }

//    public void Excute(double basicWage)
//    {
//        if (_observableList != null)
//        {
//            if (_observableList.GetInvocationList().Count() != 0)
//            {
//                _observableList(basicWage);

//            }
//        }
//    }
//}

//class Manager
//{
//    public double GetWage(double basicWage)
//    {
//        double totalWage = basicWage * 1.5;
//        Console.WriteLine("Manager's wages is : " + totalWage);
//        return totalWage;

//    }
//}

//class Worker
//{
//    public double GetWage(double basicWage)
//    {
//        double totalWage = basicWage * 1.1;
//        Console.WriteLine("Worker's wages is : " + totalWage);
//        return totalWage;

//    }
//}