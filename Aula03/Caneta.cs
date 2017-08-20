using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    public class Caneta
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        private double Ponta { get; set; }
        protected int Carga { get; set; }
        protected Boolean Tampada { get; set; }

        public void Status()
        {
            Console.WriteLine("Modelo: {0}", Modelo);
            Console.WriteLine("Uma caneta {0} ", Cor);
            Console.WriteLine("Ponta: {0}", Ponta);
            Console.WriteLine("Carga: {0}", Carga);
            Console.WriteLine("Está tampada? {0}", Tampada ? "Sim" : "Não");
        }

        public void Rabiscar()
        {
            if (Tampada) {
                Console.WriteLine("Erro, não posso rabiscar");
            } else
            {
                Console.WriteLine("Estou rabiscando");
            }
        }

        protected void Tampar()
        {
            Tampada = true;
        }

        protected void Destampar()
        {
            Tampada = false;
        }

    }
}
