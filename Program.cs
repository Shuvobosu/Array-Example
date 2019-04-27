using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_example
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[10]; //for string type
            names[0] = "shuvo";
            names[1] = "sabuj";
            names[2] = "dipok";
            names[3] = "dipto";
            string aName = names[2];
            //Console.WriteLine(aName);

            int[] numberlist = new int[3]; // for integer type
            numberlist[0] = 10;
            numberlist[1] = 20;
            int aNumberlist = numberlist[0];
            Console.WriteLine(aNumberlist);


            Console.ReadKey();

        }
    }
}
