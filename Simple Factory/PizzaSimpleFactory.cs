using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class PizzaSimpleFactory
    {
        public static Pizza CriaPizza(string nome)
        {
            Pizza pizza;
            switch (nome)
            {
                case "C":
                    pizza = new PizzaCalabreza();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A Pizza {nome} não foi criada.");
            }
            return pizza;
        }
    }
}
