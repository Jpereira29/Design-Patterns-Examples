using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class SPPizzaMussarela : Pizza
    {
        public SPPizzaMussarela()
        {
            Nome = "Pizza de mussarela Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmessão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
