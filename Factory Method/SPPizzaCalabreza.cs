using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class SPPizzaCalabreza : Pizza
    {
        public SPPizzaCalabreza()
        {
            Nome = "Pizza de calabresa Paulista com muita calabresa";
            massa = "Massa fina crocante";
            molho = "Molho de tomate italiano";
            ingredientes.Add("Fatias de calabreza defumada especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
