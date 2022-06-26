using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9E3
{
    public abstract class Veiculos
    {
        public abstract void Acelerar();

        public abstract void Freiar();
       
    }
    internal class Bicicleta : Veiculos
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a bicicleta...");
        }

        public override void Freiar()
        {
            Console.WriteLine("Freiando a bicicleta...");
        }

        public string AjustarCorreia()
        {
            return "A correia da bicicleta foi ajustada!";
        }
    }
    internal class Carro : Veiculos
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando o carro...");
        }

        public override void Freiar()
        {
            Console.WriteLine("Freiando o carro...");
        }

        public string TrocarOleo()
        {
            return "O óleo do carro foi trocado";
        }

    }
}
