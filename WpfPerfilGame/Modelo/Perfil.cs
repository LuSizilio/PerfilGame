using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Perfil
    {
        public string categoria { get; set; }
        public string nome { get; set; }
        public List<Dica> dicas;
        public Perfil()
        {
            this.categoria = "";
            this.nome = "";
            this.dicas = null;
        }
        public Perfil(string acategoria, string anome)
        {
            this.categoria = acategoria;
            this.nome = anome;
        }
        public void AddDica(Dica d)
        {
            this.dicas.Add(d);
        }
    }
}
