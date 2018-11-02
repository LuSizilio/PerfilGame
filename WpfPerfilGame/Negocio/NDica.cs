using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NDica
    {
        private List<Perfil> perfis;
        private PPerfil pc = new PPerfil();

        public List<Dica> Select(string perfil)
        {
            perfis = pc.Abrir();
            Perfil obj = perfis.Where(x => x.nome == perfil).Single();
            return obj.dicas;
        }

        public Dica SelectDica(string perfil, int dica)
        {
            perfis = pc.Abrir();
            Perfil obj = perfis.Where(x => x.nome == perfil).Single();
            return obj.dicas[dica];
        }

        public void Insert(string perfil, Dica c)
        {
            perfis = pc.Abrir();
            Perfil obj = perfis.Where(x => x.nome == perfil).Single();
            Perfil perfilnovo = obj;
            perfilnovo.dicas.Add(c);
            perfis.Remove(obj);
            perfis.Add(perfilnovo);
            pc.Salvar(perfis);
        }
    }
}
