using Aula002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Caneta();
            c1.Modelo = "Bic cristal";
            c1.Cor = "Azul";
            //c1.Ponta = 1.5;
            //c1.Carga = 1;
            c1.Status();

            Console.ReadLine();

        }
    }
}
