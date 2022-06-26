using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace A5E3
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o número da operação que deseja realizar:\n1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Calculadora.Soma(num1, num2);
                    break;
                //case 2:
                //    Calculadora subtraction = new Calculadora();
                //    Console.WriteLine(subtraction.Sub());
                //    break;
                //case 3:
                //    Calculadora division = new Calculadora();
                //    Console.WriteLine(division.Soma());
                //    break;
                //case 4:
                //    Calculadora multiplication = new Calculadora();
                //    Console.WriteLine(multiplication.Soma());
                //    break;

            }

        }
    }


}