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
        private static List<Perfil> perfisUsados;
        public static void SetPerfisUsados()
        {
            perfisUsados = new List<Perfil>();
        }
        private PPerfil pc = new PPerfil();

        public List<Perfil> Select()
        {
            perfis = pc.Abrir();
            return perfis;
        }

        public Perfil GetPerfil(string nome)
        {
            perfis = pc.Abrir();
            foreach(Perfil n in perfis)
            {
                if(n.nome == nome)
                {
                    return n;
                }
            }
            return null;
        }

        public Perfil PerfilAleatorio()
        {
            int aux = 0;
            Random rnd = new Random();
            perfis = pc.Abrir();
            Perfil p = new Perfil();
            do
            {
                aux = 0;
                if(perfis.Count() != perfisUsados.Count()) {
                    p = perfis[rnd.Next(0, perfis.Count())];
                    if (perfisUsados.Count != 0)
                    {
                        foreach (Perfil d in perfisUsados)
                        {
                            if (d.nome == p.nome)
                            {
                                aux = 1;
                            }
                        }
                    }
                    if(aux == 0)
                    {
                        perfisUsados.Add(p);
                    }
                }
            } while (aux == 1);
            
            return p;
        }

        public void Insert(Perfil c)
        {
            perfis = pc.Abrir();
            foreach (Perfil d in perfis)
            {
                if (d.nome == c.nome)
                {
                    throw new Exception();
                }
            }
            perfis.Add(c);
            pc.Salvar(perfis);
        }

        public void Delete(Perfil c)
        {
            perfis = pc.Abrir();
            foreach (Perfil d in perfis)
            {
                if (d.nome == c.nome)
                {
                    c = d;
                    
                }
            }
            perfis.Remove(c);
            pc.Salvar(perfis);
        }

        //Adicionar Perfis Inciais - Obs: Por enquanto são exemplos
        public void PerfisInciais()
        {
            NDica NDica = new NDica();
            string NomePerfil;
            //Perfil: Pessoa - Luciano
            NomePerfil = "Luciano";
            Perfil perfil = new Perfil("Pessoa", NomePerfil);
            Insert(perfil);
            Dica dica = new Dica(1, "é um estudante");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(2, "atualmente cursa o curso de informática para internet");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(3, "está no 3° ano");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(4, "é trouxa");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(5, "CEO da DCL Corp.");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(6, "Ama sorvete");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(7, "Gosta da frança");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(8, "Quer morar no canadá");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(9, "Seu nome significa Nascido da luz");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(10, "Perca a vez");
            NDica.Insert(NomePerfil, dica);

            //Perfil: Pessoa - Fabiano Papaiz
            NomePerfil = "Fabiano Papaiz";
            perfil = new Perfil("Pessoa", NomePerfil);
            Insert(perfil);
            dica = new Dica(1, "é um professor");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(2, "da aula de banco de dados para alunos do técnico");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(3, "é uma marca de cadeado");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(4, "torce para o corinthians");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(5, "Perca a vez");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(6, "Escolha um jogador para perder a vez");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(7, "é um pouco alto");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(8, "Um dos professores do projeto integrador");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(9, "Estou sem criatividade. perca a vez");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(10, "Gosta de sorvete. (eu acho, porque todo mundo gosta)");
            NDica.Insert(NomePerfil, dica);

            //Perfil: Pessoa - Alexandre
            NomePerfil = "Alexandre";
            perfil = new Perfil("Pessoa", NomePerfil);
            Insert(perfil);
            dica = new Dica(1, "Escolha um jogador para perder a vez");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(2, "da aula de APOO para alunos do técnico");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(3, "é um professor");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(4, "Perca a vez");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(5, "da aula de design web");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(6, "da aula para o 2° ano");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(7, "da aula para o 3° ano");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(8, "Gosta de sorvete. ( Eu acho :D )");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(9, "Não é alexandro ou alessandro");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(10, "é o coordenador do curso");
            NDica.Insert(NomePerfil, dica);

            //Perfil: Ano - 2000
            NomePerfil = "2000";
            perfil = new Perfil("Ano", NomePerfil);
            Insert(perfil);
            dica = new Dica(1, "Nasceu uma estrela brilhante");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(2, "No dia 09/11 foi o nascimento do CEO da DCL Corp.");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(3, "É um ano bissexto");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(4, "É o Final de uma década");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(5, "É o Final de um século");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(6, "8 de Dezembro - O juiz aposentado Nicolau dos Santos Neto é preso depois de 8 meses foragido.");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(7, "13 de dezembro - George Bush é eleito presidente dos Estados Unidos, vencendo o candidato democrata Al Gore.");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(8, "26 de Outubro - A Sony lança seu videogame nos Estados Unidos, o Playstation 2");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(9, "14 de Setembro - A Microsoft lança o Windows ME, sendo considerado um dos maiores fiascos da empresa.");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(10, "1 de Agosto - Lançamento do jogo virtual de interação online Habbo Hotel");
            NDica.Insert(NomePerfil, dica);

            //Perfil: Lugar - França
            NomePerfil = "França";
            perfil = new Perfil("Lugar", NomePerfil);
            Insert(perfil);
            dica = new Dica(1, "Pode ser um nome de pessoa");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(2, "Pode ser um sobrenome");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(3, "é um país");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(4, "Sua capital é Paris");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(5, "Onde fica a torre eiffel");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(6, "CEO da DCL Corp gosta");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(7, "Sua seleção foi campeã da copa do mundo de 2018");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(8, "5° seleção que mais pontuou ao longo da história até a copa do mundo de 2018");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(9, "O jogador Neymar Jr. atualmente joga por um time desse país");
            NDica.Insert(NomePerfil, dica);

            dica = new Dica(10, "é bonita");
            NDica.Insert(NomePerfil, dica);
        }
    }
}
