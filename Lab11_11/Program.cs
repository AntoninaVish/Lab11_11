using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation linearEquation = new Equation ();
            try
            {
                Console.WriteLine("Программа находит значение линейного уравнения первого порядка вида 0=kx+b");
                Console.Write("Введите значение коэффициента k=");
                linearEquation.coefK = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение коэффициента b=");
                linearEquation.coefB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода значения");
                Console.ReadKey();
                return;
            }
            linearEquation.Root(); 
            Console.ReadKey();
            
        }
    
        struct Equation
        {
            public double coefK;
            public double coefB;
                        
            public void Root()
            {
                if (coefK == 0 && coefB!=0)
                {
                    Console.WriteLine("У уровнения не может быть решений.");
                }
                else if (coefK == 0 && coefB == 0)
                {
                    Console.WriteLine("Решений бесконечно много.");
                }
                else
                {
                    Console.WriteLine("Решение уровнения x={0}", -coefB / coefK);
                }
                
            }
        }
           
    }   
    
}
