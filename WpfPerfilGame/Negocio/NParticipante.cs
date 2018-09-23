using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NParticipante
    {
        private List<Participante> participantes;
        private PParticipante pc = new PParticipante();

        public List<Participante> Select()
        {
            participantes = pc.Abrir();
            return participantes;
        }

        public void Insert(Participante c)
        {
            participantes = pc.Abrir();
            foreach (Participante d in participantes)
            {
                if (d.GetId() == c.GetId())
                {
                    return;
                }
            }
            participantes.Add(c);
            pc.Salvar(participantes);
        }

        public void Limpar()
        {
            participantes = new List<Participante>();
            pc.Salvar(participantes);
        }

        public void GerarOrdem(int qnt)
        {
            participantes = pc.Abrir();
            List<Participante> participantes1 = new List<Participante>();
            List<int> numeros = new List<int>();
            Random rnd = new Random();
            for(int x = 0; x < qnt; x++)
            {
                int aux;
                do aux = rnd.Next(1, qnt + 1);
                while (numeros.Contains(aux));
                numeros.Add(aux);
                foreach(Participante p in participantes)
                {
                    if(p.GetId() == x)
                    {
                        p.SetOrdem(aux);
                        participantes1.Add(p);
                    }
                    
                }
                
            }
            participantes = participantes1;
            pc.Salvar(participantes);
        }

        public string GetMediador()
        {
            participantes = pc.Abrir();
            Modelo.Participante r = participantes.Where(x => x.ordem == 1).Single();
            return r.nome;
        }

        public Participante GetJogadorVez()
        {
            participantes = pc.Abrir();
            Modelo.Participante r = participantes.Where(x => x.ordem == Modelo.Participante.GetRodada()).Single();
            return r;
        }

    }
}
