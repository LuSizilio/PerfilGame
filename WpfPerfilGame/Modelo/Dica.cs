using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Dica
    {
        public int numero { get; set; }
        public string texto { get; set; }
        public Dica()
        {
            this.numero = 0;
            this.texto = "";
        }
        public Dica(int anumero, string atexto)
        {
            this.numero = anumero;
            this.texto = atexto;
        }
    }
}
