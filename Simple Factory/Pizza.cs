using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal abstract class Pizza
    {
        public string? Nome { get; set; }
        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} Assando por {tempo} min.");
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }

        public void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}");
        }
    }
}
