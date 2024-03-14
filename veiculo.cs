using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Veiculo
        {
            public double Distancia_P { get; set; }
            public string Modelo { get; set; }

            public void Andar()
            {
                Console.WriteLine("andando");
                double distancia;
                distancia = Distancia_P;
            }
        }

        public class Moto : Veiculo
        {
            public string Rodas { get; } = "2 rodas";

            public void Empinar()
            {
                Console.WriteLine("Está empinando");
            }
        }

        public class Carro : Veiculo
        {
            public string Rodas { get; } = "4 rodas";

            public void Zerinho()
            {
                Console.WriteLine("Está dando zerinho");
            }
        }

        static void Main(string[] args)
        {
            Moto pop = new Moto();
            Carro gol = new Carro();

            pop.Empinar();
            gol.Zerinho();
            Console.ReadLine();
        }
    }
}
