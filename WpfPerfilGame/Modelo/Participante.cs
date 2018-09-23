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

        //GlobalVar
        private static int JogadorRodada = 2;
        public static void NovaRodada()
        {
            JogadorRodada = 2;
        }
        public static void AddRodada()
        {
            JogadorRodada += 1;
            if (JogadorRodada > 4)
                JogadorRodada = 1;
        }
        public static int GetRodada()
        {
            return JogadorRodada;
        }
    }
}
