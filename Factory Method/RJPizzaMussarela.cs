using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {
            Nome = "Pizza de calabreza Carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmessão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}
