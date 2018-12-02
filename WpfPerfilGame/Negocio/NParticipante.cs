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

        public Participante GetMediador()
        {
            participantes = pc.Abrir();
            Modelo.Participante r = participantes.Where(x => x.ordem == Participante.GetMediador()).Single();
            return r;
        }

        public Participante GetJogadorVez()
        {
            participantes = pc.Abrir();
            Modelo.Participante r = participantes.Where(x => x.ordem == Participante.GetJogadorVez()).Single();
            return r;
        }

        public void NovaRodada()
        {
            Participante.SetMediador();
        }
        public void SetJogadorVez()
        {
            Participante.SetJogadorVez();
        }

        public void UpdatePontos(int id,int pontos)
        {
            participantes = pc.Abrir();
            foreach (Participante p in participantes)
            {
                if (p.GetId() == id)
                {
                    participantes.Remove(p);
                    p.SetPlacar(pontos);
                    participantes.Add(p);
                    break;
                }

            }
            pc.Salvar(participantes);
        }

        public void CriarPartida(string qnt, string txtP1, string txtP2, string txtP3, string txtP4)
        {
            if (qnt != "1" && qnt != "2" && qnt != "0") throw new ArgumentException();
            Participante p;
            Limpar();
            p = new Participante(0, txtP1);
            Insert(p);
            p = new Participante(1, txtP2);
            Insert(p);
            Participante.SetQnt(2);
            if (qnt == "1")
            {
                p = new Participante(2, txtP3);
                Insert(p);
                Participante.SetQnt(3);
            }
            else if (qnt == "2")
            {
                p = new Participante(2, txtP3);
                Insert(p);
                p = new Participante(3, txtP4);
                Insert(p);
                Participante.SetQnt(4);
            }
            GerarOrdem(Participante.GetQnt());
            NPerfil.SetPerfisUsados();
        }
    }
}
