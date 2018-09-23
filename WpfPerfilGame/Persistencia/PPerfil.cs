using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;


namespace Persistencia
{
    public class PPerfil : Arquivo<List<Perfil>>
    {
        public PPerfil() : base("lperfil.xml")
            {
        }
    }
}
