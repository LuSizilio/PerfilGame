using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Participante
    {
        public int id;
        public string nome {get;set;}
        public int ordem;
        public int placar;
        public Participante()
        {
            this.id = 0;
            this.nome = "";
            this.ordem = 0;
            this.placar = 0;
        }
        public Participante(int aid,string anome)
        {
            this.id = aid;
            this.nome = anome;
            this.ordem = 0;
            this.placar = 0;
        }
        public void SetOrdem(int aordem)
        {
            this.ordem = aordem;
        }
        public int GetId()
        {
            return id;
        }
        public int GetOrdem()
        {
            return ordem;
        }
        public void SetPlacar(int aplacar)
        {
            this.placar += aplacar;
        }

        //GlobalVar
        private static int JogadorVez = 0;
        private static int qntJogadores = 0;
        private static string Ganhador = "";
        private static int Mediador = 0;
        public static void SetJogadorVez()
        {
            do
            {
                JogadorVez += 1;
                if (JogadorVez > qntJogadores)
                    JogadorVez = 1;
                
            }
            while (JogadorVez == Mediador);
        }
        public static void SetMediador()
        {
            Mediador += 1;
            if (Mediador > qntJogadores)
                Mediador = 1;
            JogadorVez = Mediador;
        }
        public static int GetMediador()
        {
            return Mediador;
        }
        public static int GetJogadorVez()
        {
            return JogadorVez;
        }
        public static string GetGanhador()
        {
            return Ganhador;
        }
        public static void SetGanhador(string aGanhador)
        {
            Ganhador = aGanhador;
        }
        public static void SetQnt(int i)
        {
            Ganhador = "";
            qntJogadores = i;
        }
        public static int GetQnt()
        {
            return qntJogadores;
        }
    }
}
