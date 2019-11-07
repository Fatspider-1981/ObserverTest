using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    public class WageManager : IEmployee
    {

        private Observerable _observableList;

        public double GetWages(double basicWages)
        {
            double totalWages = 1.8 * basicWages;
            Console.WriteLine("WageManager's wages is : " + totalWages);
            return totalWages;
        }

        //加入观察者
        public void Attach(Observerable observable)
        {
            _observableList += observable;
        }

        //删除观察者
        public void Detach(Observerable observable)
        {
            _observableList -= observable;
        }

        //通过GetInvodationList方法获取多路广播委托列表，如果观察者数量大于0即执行方法
        public void Calculate(double observableWages)
        {
            if (_observableList != null)
                if (_observableList.GetInvocationList().Count() != 0)
                    _observableList(observableWages);
        }
    }
}
