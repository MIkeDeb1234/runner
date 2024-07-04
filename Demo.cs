using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace runner
{
    public class Demo
    {
        public static void Load()
        {
            Console.WriteLine("Hello World!");
            File.WriteAllText("test.txt", "Hello World!");


        }

    }
}