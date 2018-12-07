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
    /// Interação lógica para PageListarDicas.xam
    /// </summary>
    public partial class PageListarDicas : Page
    {
        public PageListarDicas()
        {
            InitializeComponent();
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            try
            {
                Modelo.Perfil p = NPerfil.GetPerfil(PageListarPerfil.EditarNome);
                txtPerfil.Text = p.nome;
                Negocio.NDica NDicas = new Negocio.NDica();
                switch (p.categoria)
                {
                    case "Pessoa":
                        CbCategoria.SelectedIndex = 0;
                        break;
                    case "Ano":
                        CbCategoria.SelectedIndex = 1;
                        break;
                    case "Lugar":
                        CbCategoria.SelectedIndex = 2;
                        break;
                }
                foreach (Modelo.Dica d in NDicas.Select(p.nome))
                {
                    switch (d.numero)
                    {
                        case 1:
                            txtD1.Text = d.texto;
                            break;
                        case 2:
                            txtD2.Text = d.texto;
                            break;
                        case 3:
                            txtD3.Text = d.texto;
                            break;
                        case 4:
                            txtD4.Text = d.texto;
                            break;
                        case 5:
                            txtD5.Text = d.texto;
                            break;
                        case 6:
                            txtD6.Text = d.texto;
                            break;
                        case 7:
                            txtD7.Text = d.texto;
                            break;
                        case 8:
                            txtD8.Text = d.texto;
                            break;
                        case 9:
                            txtD9.Text = d.texto;
                            break;
                        case 10:
                            txtD10.Text = d.texto;
                            break;
                    }
                }
            }
            catch
            {
                BtnDPerfil.IsEnabled = false;
                BtnDPerfil.Visibility = Visibility.Hidden;
                Grid.SetRow(BtnSPerfil,7);
            }
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageListarPerfil.xaml", UriKind.Relative));
        }

        private void BtnDPerfil_Click(object sender, RoutedEventArgs e)
        {
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            Modelo.Perfil p = NPerfil.GetPerfil(PageListarPerfil.EditarNome);
            NPerfil.Delete(p);
            NavigationService.Navigate(new Uri("/PageListarPerfil.xaml", UriKind.Relative));
        }

        private void BtnSPerfil_Click(object sender, RoutedEventArgs e)
        {
            Negocio.NDica NDica = new Negocio.NDica();
            Negocio.NPerfil NPerfil = new Negocio.NPerfil();
            
                try { 
                    string categoria = "";
                    string NomePerfil = txtPerfil.Text;
                    switch (CbCategoria.SelectedIndex)
                    {
                        case 0:
                            categoria = "Pessoa";
                            break;
                        case 1:
                            categoria = "Ano";
                            break;
                        case 2:
                            categoria = "Lugar";
                            break;
                    }
                    if (NomePerfil == "" || txtD1.Text == "" || txtD2.Text == "" || txtD3.Text == "" || txtD4.Text == "" || txtD5.Text == "" || txtD6.Text == "" || txtD7.Text == "" || txtD8.Text == "" || txtD9.Text == "" || txtD10.Text == "") throw new Exception();
                if (PageListarPerfil.EditarNome != null)
                {
                    Modelo.Perfil p = NPerfil.GetPerfil(PageListarPerfil.EditarNome);
                    NPerfil.Delete(p);
                }

                Modelo.Perfil perfil = new Modelo.Perfil(categoria, NomePerfil);
                    NPerfil.Insert(perfil);
                    Modelo.Dica dica = new Modelo.Dica(1, txtD1.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(2, txtD2.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(3, txtD3.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(4, txtD4.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(5, txtD5.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(6, txtD6.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(7, txtD7.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(8, txtD8.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(9, txtD9.Text);
                    NDica.Insert(NomePerfil, dica);

                    dica = new Modelo.Dica(10, txtD10.Text);
                    NDica.Insert(NomePerfil, dica);
                NDica.Insert(NomePerfil, dica);
                NavigationService.Navigate(new Uri("/PageListarPerfil.xaml", UriKind.Relative));

                }
                catch
                {
                    MessageBox.Show("Erro ao criar perfil, certifique-se se o perfil não existe ou se não há campos vazios");
                }
            
        }
    }
}
