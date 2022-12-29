using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class RJPizzaCalabreza : Pizza
    {
        public RJPizzaCalabreza()
        {
            Nome = "Pizza de calabreza Carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabraza especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
