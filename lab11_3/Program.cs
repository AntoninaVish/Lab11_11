using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation linearEquation = new Equation();
            try
            {
                Console.WriteLine("Программа находит значение линейного уравнения первого порядка вида 0=kx+b");
                Console.WriteLine("Введите значение коэффициента k=");
                linearEquation.coefK = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение коэффициента b=");
                linearEquation.coefB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода значения");
                Console.ReadKey();
                return;
            }
            linearEquation.Root(1,0);
            
            Console.ReadKey();

        }

        struct Equation
        {
            public double coefK;
            public double coefB;
            public double s;       
            public void Root(double coefK, double coefB)
            {
                double x = -coefB / coefK;
                s = coefK * x + coefB;
                Console.WriteLine(s);
                
            }
        }

    }
}
