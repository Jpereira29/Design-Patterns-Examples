using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal  abstract class Pizza
    {
        protected string? Nome { get; set; }
        protected string? massa;
        protected string? molho;
        protected ArrayList ingredientes = new ArrayList();

        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Preparando" + Nome + "\n");
            sb.Append(massa + "\n");
            sb.Append(molho + "\n");
            sb.Append("Ingredientes:" + "\n");
            foreach (string ingrediente in ingredientes)
            {
                sb.Append("\t" + ingrediente + "\n");
            }
            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());
            return sb.ToString();
        }

        private string Embalar()
        {
            return "Embalar a pizza com embalagem oficial \n";
        }

        private string Fatiar()
        {
            return "Fatiar a pizza em 8 pedaços \n";
        }

        private string Cozinhar()
        {
            return "Cozinhar por mais 25 minutos a 350 graus \n";
        }
    }
}
