using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetParams("1", "2", "3");

            testarray(new string[] { "1", "2", "3" });
            Console.ReadLine();
        }

        static void GetParams (params string[] parameters)
        {
            foreach (var t1 in parameters)
            {
                Console.WriteLine(t1);
            }

            List<string> listOfParams = new List<string>();
            foreach (var t1 in parameters)
            {
                listOfParams.Add(t1);
            }

            listOfParams.ToArray();
          

            foreach (var t2 in listOfParams)
            {
                Console.WriteLine("new p2 = " + t2);
            }
        }

        static void testarray(string[] str)
        {
            foreach (var t2 in str)
            {
                Console.WriteLine("new p3 = " + t2);
            }
        }
    }
}
