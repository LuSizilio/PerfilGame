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
    public class PParticipante : Arquivo<List<Participante>>
    {
        public PParticipante() : base("lparticipante.xml")
        {
        }
    }
}
