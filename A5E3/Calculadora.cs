using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5E3
{
    abstract class Calculadora
    {
      
        public virtual void Menu()
        {
            Console.WriteLine("Insira um número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o número da operação que deseja realizar:\n1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação");
            int op = int.Parse(Console.ReadLine());
        }
        
        public virtual void Soma()
        {
            if (int op);
        }

        public void Sub()
        {
            Console.WriteLine();
        }

        public void Div()
        {
            Console.WriteLine();
        }

        public void Mult()
        {
            Console.WriteLine();
        }

    }


}
