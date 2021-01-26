using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_inter_face
{
    class Program
    {
        static void Main(string[] args)
        {
            hesap d = new Display(100,500);

            float tota = d.aear();
            Console.WriteLine(tota);
            Console.ReadKey();


        }
    }
}
