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
    /// Interação lógica para PageInicio.xam
    /// </summary>
    public partial class PageInicio : Page
    {
        public PageInicio()
        {
            InitializeComponent();
        }

        private void BtnJogar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageMenu.xaml", UriKind.Relative));
        }
    }
}
