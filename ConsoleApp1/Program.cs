using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                return;
            }
            linearEquation.GetVariable();
        }
    }       
    class Equation
    {
        public double VariableX { get; set; } d;
        public double coefB { get; set; }
        public double coefK;
        {
            set
            {
                if (value != 0)
               {
                    coefK = value;
           }
            else
                {
                    Console.WriteLine("Коэфициент k не может быть равен 0");
       }
                }
                receive
                {
                return (coefK);
       }
            }
            public Equation()
            {
               this.VariableX = variableX;
               this.CoefB = coefB;
               this.CoefK = coefK; 

            }
            public void GetVariable();
            {

}


    }
            }
        }
    }

            }
            
            Cat cat = new Cat(); //использовать конструктор по умолчанию, т.е для строк присвоет пустое значение, а в целочисленное поле age присвоит ноль
            Cat cate = new Cat { name = "Мурка", color = "Черный", age = 1 }; //это используем инициализатор-это вызов конструктора в котором мы сразу присваиваем значение  
            cat.name = "Мурка"; // проинициализировать поля
            cat.color = "Черный";// проинициализировать поля
            cat.age = 1;// проинициализировать поля
            cat.Say(); //проинициализировать поля

        }
        struct Equation
        {
           public float coefK;
           public float coefB;
           public double variableX;

            public void Root()
            {
                Console.WriteLine("Мяу");

            }
        }
    }

}
    

