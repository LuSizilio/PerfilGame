using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfPerfilGame
{
    /// <summary>
    /// Interação lógica para PageJogadorVez.xam
    /// </summary>
    public partial class PageJogadorVez : Page
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public PageJogadorVez()
        {
            InitializeComponent();

            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Modelo.Participante p = NParticipante.GetJogadorVez();
            txtParticipanteVez.Text = p.nome;

            //Timer

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        int TimeLeft = 5;
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft >= 0)
            {
                Timer.Text = TimeLeft.ToString();
                TimeLeft -= 1;
            }
            else
            {
                dispatcherTimer.Stop();
            }

        }
    }
}
