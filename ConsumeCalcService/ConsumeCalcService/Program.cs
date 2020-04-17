using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeCalcService
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcService.CalcServiceSoapClient calc =
                new CalcService.CalcServiceSoapClient();
            Console.WriteLine("Add:" +calc.add(10,20));
            Console.WriteLine("Add:" + calc.add(50, 20));
            Console.ReadLine();
        }
    }
}
