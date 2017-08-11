using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Caneta();
            c1.Cor = "Azul";
            c1.Ponta = 0.5F;
            c1.Tampar();           
            c1.Status();
            c1.Rabiscar();
            
            Console.WriteLine("--------------------------------");

            var c2 = new Caneta();
            c2.Modelo = "Hostnet";
            c2.Cor = "Preta";
            c2.Destampar();
            c2.Status();
            c2.Rabiscar();

            Console.ReadLine();

        }
    }
}
