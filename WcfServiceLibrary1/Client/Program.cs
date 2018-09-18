using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DemoServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClient demoClient = new DemoClient("BasicHttpBinding_IDemo");
            EmpData empData = new EmpData()
            {
                EmpId = "21",
                EmpName = "shri"
            };
            Console.WriteLine(demoClient.GetEmpData(empData));
            Console.ReadKey();
        }
        
    }
}
