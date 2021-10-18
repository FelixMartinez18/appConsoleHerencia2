using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appConsoleHerencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a;
            a = new Alumno("Felix Rafael Martinez Machuca", "28/08/03", 21050342, "informatica");
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
