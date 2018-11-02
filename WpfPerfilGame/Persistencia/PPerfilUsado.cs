using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Persistencia
{
    public class PPerfilUsado : Arquivo<List<Perfil>>
    {
        public PPerfilUsado() : base("lperfisusados.xml")
        {
        }
    }
}
