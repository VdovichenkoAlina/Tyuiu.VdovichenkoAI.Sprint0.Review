using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VdovichenkoAI.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;
            
            Console.WriteLine("(x + y + z)*5");

            Console.WriteLine(DataService.Calc(x, y, z));

            Console.ReadKey();
        }
    }
}
