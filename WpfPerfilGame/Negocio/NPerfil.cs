using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NPerfil
    {
        private List<Perfil> perfis;
        private PPerfil pc = new PPerfil();

        public List<Perfil> Select()
        {
            perfis = pc.Abrir();
            return perfis;
        }

        public Perfil PerfilAleatorio()
        {
            Random rnd = new Random();
            perfis = pc.Abrir();
            Perfil p = perfis[rnd.Next(0,perfis.Count())];
            return p;
        }

        public void Insert(Perfil c)
        {
            perfis = pc.Abrir();
            foreach (Perfil d in perfis)
            {
                if (d.nome == c.nome)
                {
                    return;
                }
            }
            perfis.Add(c);
            pc.Salvar(perfis);
        }
    }
}
