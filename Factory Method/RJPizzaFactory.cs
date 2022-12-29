using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class RJPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new RJPizzaMussarela();
            }
            if (tipo.Equals("C"))
            {
                return new RJPizzaCalabreza();
            }
            else return null;
        }
    }
}
