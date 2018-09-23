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
    /// Interação lógica para PagePerfil.xam
    /// </summary>
    public partial class PagePerfil : Page
    {
        public PagePerfil()
        {
            InitializeComponent();
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            Modelo.Perfil perfil = NPerfil.PerfilAleatorio();
            txtCategoria.Text = perfil.categoria;
            txtPerfil.Text = perfil.nome;
            Negocio.NDica NDica = new Negocio.NDica();
            listDicas.ItemsSource = NDica.Select(perfil.nome);
        }

        private void BtnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageJogadorVez.xaml", UriKind.Relative));
        }
    }
}
