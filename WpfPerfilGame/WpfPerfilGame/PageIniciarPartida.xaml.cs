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

namespace WpfPerfilGame
{
    /// <summary>
    /// Interação lógica para PageIniciarPartida.xam
    /// </summary>
    public partial class PageIniciarPartida : Page
    {
        public PageIniciarPartida()
        {
            InitializeComponent();
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            if(NPerfil.Select().Count() == 0)NPerfil.PerfisInciais();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CBPlayers.SelectedIndex.ToString() == "1")//1 = 3 players
            {
                txtP3.Visibility = Visibility.Visible;
            }
            else
            {
                txtP3.Visibility = Visibility.Hidden;
            }
            if (CBPlayers.SelectedIndex.ToString() == "2")//2 = 4 players
            {
                txtP4.Visibility = Visibility.Visible;
                txtP3.Visibility = Visibility.Visible;
            }
            else
            {
                txtP4.Visibility = Visibility.Hidden;
            }
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageMenu.xaml", UriKind.Relative));
        }

        private void BtnAvancar_Click(object sender, RoutedEventArgs e)
        {
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            NParticipante.CriarPartida(CBPlayers.SelectedIndex.ToString(), txtP1.Text, txtP2.Text, txtP3.Text, txtP4.Text);
            NavigationService.Navigate(new Uri("/PageMediador.xaml", UriKind.Relative));
        }
    }
}
