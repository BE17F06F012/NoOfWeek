using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{

    class Program
    {
        enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        static void Main(string[] args)
        {
            Console.WriteLine("enum Demo");
            int firstday = (int)Days.Mon;
            int lastday = (int)Days.Sun;
            Console.WriteLine("Mon :{0}", firstday);
            Console.WriteLine("Sun:{0}", lastday);
            Console.ReadLine();
           

        }
    }
}
