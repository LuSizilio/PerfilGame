using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WpfPerfilGame
{
    [TestClass]
    public class TestIniciarPartida
    {
        //Verifica se quantidade de jogadores não é válida(0,1 ou 2 obs.: 0 = 2 Players, 1 = 3 Players e 2 = 4 Players)
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCriarPartida1()
        {
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            NParticipante.CriarPartida("-1", "Teste", "Ok", "", "");
        }

        //Verifica se participantes foram criados
        [TestMethod]
        public void TestCriarPartida2()
        {
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            NParticipante.CriarPartida("2", "Teste1", "Teste2", "Teste3", "Teste4");           
            List<Modelo.Participante> p1 = NParticipante.Select();
            int x = 1;
            foreach(Modelo.Participante p in p1)
            {
                Assert.AreEqual(p.nome,"Teste"+x++);
            }
        }
    }

    [TestClass]
    public class CriarRodada
    {
        //Teste para ver se mediador fica diferente
        [TestMethod]
        public void TestCriarRodada1()
        {
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            NPerfil.PerfisInciais();
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Negocio.NDica NDica = new Negocio.NDica();
            NParticipante.CriarPartida("2", "Teste1", "Teste2", "Teste3", "Teste4");
            NParticipante.NovaRodada();
            Modelo.Participante p1 = NParticipante.GetMediador();
            NParticipante.NovaRodada();
            Modelo.Participante p2 = NParticipante.GetMediador();
            Assert.AreNotEqual(p1.nome, p2.nome);
        }

        //Teste para ver se Jogador volta a ser mediador depois
        [TestMethod]
        public void TestCriarRodada2()
        {
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            NPerfil.PerfisInciais();
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Negocio.NDica NDica = new Negocio.NDica();
            NParticipante.CriarPartida("0", "Teste1", "Teste2", "", "");
            NParticipante.NovaRodada();
            Modelo.Participante p1 = NParticipante.GetMediador();
            NParticipante.NovaRodada();
            NParticipante.NovaRodada();
            Modelo.Participante p2 = NParticipante.GetMediador();
            Assert.AreEqual(p1.nome, p2.nome);
            
            
        }
    }

    [TestClass]
    public class TestTentarAcerto
    {
        //Verifica se dica foi utilizada ao errar
        [TestMethod]
        public void TestTentarAcerto1()
        {
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            NPerfil.PerfisInciais();
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Negocio.NDica NDica = new Negocio.NDica();
            NParticipante.CriarPartida("2", "Teste1", "Teste2", "Teste3", "Teste4");
            NParticipante.NovaRodada();
            PagePerfil p = new PagePerfil();
            Modelo.Dica d = p.VerDica("2000", 0);
            p.UsarDica(d);
            foreach (Modelo.Dica a in NDica.GetDicasUsadas())
            {
                Assert.AreEqual(a.numero, 1);
            }
        }

        //Verifica se Outra dica não foi utilizada ao errar uma dica
        [TestMethod]
        public void TestTentarAcerto2()
        {
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            NPerfil.PerfisInciais();
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Negocio.NDica NDica = new Negocio.NDica();
            NParticipante.CriarPartida("2", "Teste1", "Teste2", "Teste3", "Teste4");
            NParticipante.NovaRodada();
            PagePerfil p = new PagePerfil();
            Modelo.Dica d = p.VerDica("2000", 0);
            p.UsarDica(d);
            foreach (Modelo.Dica a in NDica.GetDicasUsadas())
            {
                Assert.AreNotEqual(a.numero, 2);
            }
        }
    }
}
