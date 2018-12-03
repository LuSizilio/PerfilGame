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
    /// Interação lógica para PageMenu.xam
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }
        private void BtnIniciarPartida_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageIniciarPartida.xaml", UriKind.Relative));
        }
        private void BtnPerfil_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageListarPerfil.xaml", UriKind.Relative));
        }
        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageInicio.xaml", UriKind.Relative));
        }
    }
}
