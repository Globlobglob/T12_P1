using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T12_P11;

namespace T12_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person("Misha","alexsandr",25);   
            Console.WriteLine(person.GetInfo());*/


           // Point point=new Point();
            //Console.WriteLine(point.ToString());


            Point point1 = new Point(2,10);
            Console.WriteLine(point1.Func());
            Console.WriteLine(point1.ToString());
           
            Console.ReadKey();


            Adress adress=new Adress(3300,"Russia","Moscow",25,160,56);
            Console.WriteLine(adress.ToString());


            Console.ReadKey();

        }
    }
}
