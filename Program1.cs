using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b) + "\n");

            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " + " + c + " = " + c + " + " + b + " + " + a + "\n");

            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " + " + c + " = " + (a + b + c) + "\n");

            Console.Write("a= ");
            float f = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("{0,3:N1} * {1,3:N1} = {2,3:N1}", f, d, f * d + "\n");

            Console.Write("a= ");
            f = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            d = float.Parse(Console.ReadLine());
            Console.WriteLine("{0,3:N3} / {1,3:N3} = {2,3:N3}", f, d, f / d +"\n");

            Console.Write("a= ");
            f = float.Parse(Console.ReadLine());
            Console.Write("b= ");
            d = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float g = float.Parse(Console.ReadLine());
            Console.WriteLine("<{0,3:N2} + {1,3:N2}> + {2,3:N2}={0,3:N2} + <{1,3:N2} + {2,3:N2}>", f, d, g +"\n");
        }
    }
}
