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
    /// Interação lógica para PageListarPerfil.xam
    /// </summary>
    public partial class PageListarPerfil : Page
    {
        public PageListarPerfil()
        {
            InitializeComponent();
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            List.ItemsSource = NPerfil.Select();
        }
        public static string EditarNome;
        private void BtnEPerfil_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Modelo.Perfil p = List.SelectedItem as Modelo.Perfil;
                EditarNome = p.nome;
                NavigationService.Navigate(new Uri("/PageListarDicas.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Selecione um Perfil");
            }
            
            
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageMenu.xaml", UriKind.Relative));
        }

        private void BtnNPerfil_Click(object sender, RoutedEventArgs e)
        {
            EditarNome = null;
            NavigationService.Navigate(new Uri("/PageListarDicas.xaml", UriKind.Relative));
        }
    }
}
