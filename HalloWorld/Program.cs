using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is first application");
            //Console.ReadLine();
            BMW ob = new BMW();
            ob.CarMaintainace();
            Console.ReadLine();
        }
    }
}
