namespace A9E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Veículos do mundo real----\nEscolha: 1- Carro ou 2- Bicicleta");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Carro carro1 = new Carro();
                carro1.Acelerar();
                carro1.Freiar();
                Console.WriteLine(carro1.TrocarOleo());
            }
            else
            {
                Bicicleta bicicleta1 = new Bicicleta();
                bicicleta1.Acelerar();
                bicicleta1.Freiar();
                Console.WriteLine(bicicleta1.AjustarCorreia());
            }

        }
    }
}