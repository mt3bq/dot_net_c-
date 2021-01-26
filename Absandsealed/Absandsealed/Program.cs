using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absandsealed
{

    abstract class person {
        public void show() {
            Console.WriteLine("Hi Muteb");

        }

    }
    class abs:person {
    }
    class Program
    {
        static void Main(string[] args)
        {
            abs a = new abs();
            a.show();

            Console.ReadKey();
            
        }
    }
}
