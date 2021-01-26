using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ex
{
    class Program
    {

        public struct Person {
            public string Full_Name;
            public int Age;
        }
        static void Main(string[] args)
        {
          
            List<Person> My_List = new List<Person>();

            
            My_List.Add(new Person {
               // Console.Write("Enter Your Full Name:"),
                Full_Name = Console.ReadLine(),
                Age=Convert.ToInt32(Console.ReadLine()),
           
        });

            foreach (var i in My_List) {
                Console.WriteLine("Name:"+i.Full_Name);
                Console.WriteLine("Age:" + i.Age);
                Console.WriteLine("***********************");
            }
            Console.ReadKey();
            
            
        }
    }
}
