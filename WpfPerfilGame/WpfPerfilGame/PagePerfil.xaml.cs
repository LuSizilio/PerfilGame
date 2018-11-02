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
            Modelo.Perfil perfilvazio = new Modelo.Perfil();
            Modelo.Perfil perfil = NPerfil.PerfilAleatorio();
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Modelo.Participante Mediador = NParticipante.GetMediador();
            txtMediador.Text = Mediador.nome;
            txtCategoria.Text = perfil.categoria;
            txtPerfil.Text = perfil.nome;
            JogarRodada();
        }

        private void JogarRodada()
        {
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            NParticipante.SetJogadorVez();
            Modelo.Participante JogadorVez = NParticipante.GetJogadorVez();
            txtJogador.Text = JogadorVez.nome;
        }

        private void BtnDica1_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 0);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica1.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica1.Background = brush;
        }
        private void BtnDica2_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 1);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica2.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica2.Background = brush;
        }
        private void BtnDica3_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 2);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica3.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica3.Background = brush;
        }
        private void BtnDica4_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 3);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica4.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica4.Background = brush;
        }
        private void BtnDica5_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 4);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica5.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica5.Background = brush;
        }
        private void BtnDica6_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 5);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica6.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica6.Background = brush;
        }
        private void BtnDica7_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 6);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica7.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica7.Background = brush;
        }
        private void BtnDica8_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 7);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica8.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica8.Background = brush;
        }
        private void BtnDica9_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 8);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica9.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica9.Background = brush;
        }
        private void BtnDica10_Click(object sender, RoutedEventArgs e)
        {
            setUnknow();
            Negocio.NDica NDica = new Negocio.NDica();
            Modelo.Dica Dica = NDica.SelectDica(txtPerfil.Text, 9);
            txtDica.Text = Dica.texto;
            txtDicaId.Text = Dica.numero.ToString();

            BtnDica10.IsEnabled = false;
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFF37735");
            brush.Freeze();
            BtnDica10.Background = brush;
        }

        private void setUnknow()
        {
            BrushConverter bc = new BrushConverter();
            Brush wrong = (Brush)bc.ConvertFrom("#FFD11141");
            wrong.Freeze();
            Brush unknow = (Brush)bc.ConvertFrom("#00b159");
            unknow.Freeze();
            if (BtnDica1.Opacity != 0.9)
            {
                BtnDica1.Background = unknow;
                BtnDica1.IsEnabled = true;
            }
            if (BtnDica2.Opacity != 0.9)
            {
                BtnDica2.Background = unknow;
                BtnDica2.IsEnabled = true;
            }
            if (BtnDica3.Opacity != 0.9)
            {
                BtnDica3.Background = unknow;
                BtnDica3.IsEnabled = true;
            }
            if (BtnDica4.Opacity != 0.9)
            {
                BtnDica4.Background = unknow;
                BtnDica4.IsEnabled = true;
            }
            if (BtnDica5.Opacity != 0.9)
            {
                BtnDica5.Background = unknow;
                BtnDica5.IsEnabled = true;
            }
            if (BtnDica6.Opacity != 0.9)
            {
                BtnDica6.Background = unknow;
                BtnDica6.IsEnabled = true;
            }
            if (BtnDica7.Opacity != 0.9)
            {
                BtnDica7.Background = unknow;
                BtnDica7.IsEnabled = true;
            }
            if (BtnDica8.Opacity != 0.9)
            {
                BtnDica8.Background = unknow;
                BtnDica8.IsEnabled = true;
            }
            if (BtnDica9.Opacity != 0.9)
            {
                BtnDica9.Background = unknow;
                BtnDica9.IsEnabled = true;
            }
            if (BtnDica10.Opacity != 0.9)
            {
                BtnDica10.Background = unknow;
                BtnDica10.IsEnabled = true;
            }
        }

        private void setWrong()
        {
            BrushConverter bc = new BrushConverter();
            Brush wrong = (Brush)bc.ConvertFrom("#FFD11141");
            wrong.Freeze();
            if (!BtnDica1.IsEnabled)
            {
                BtnDica1.Background = wrong;
                BtnDica1.Opacity = 0.9;
            }
            if (!BtnDica2.IsEnabled)
            {
                BtnDica2.Background = wrong;
                BtnDica2.Opacity = 0.9;
            }
            if (!BtnDica3.IsEnabled)
            {
                BtnDica3.Background = wrong;
                BtnDica3.Opacity = 0.9;
            }
            if (!BtnDica4.IsEnabled)
            {
                BtnDica4.Background = wrong;
                BtnDica4.Opacity = 0.9;
            }
            if (!BtnDica5.IsEnabled)
            {
                BtnDica5.Background = wrong;
                BtnDica5.Opacity = 0.9;
            }
            if (!BtnDica6.IsEnabled)
            {
                BtnDica6.Background = wrong;
                BtnDica6.Opacity = 0.9;
            }
            if (!BtnDica7.IsEnabled)
            {
                BtnDica7.Background = wrong;
                BtnDica7.Opacity = 0.9;
            }
            if (!BtnDica8.IsEnabled)
            {
                BtnDica8.Background = wrong;
                BtnDica8.Opacity = 0.9;
            }
            if (!BtnDica9.IsEnabled)
            {
                BtnDica9.Background = wrong;
                BtnDica9.Opacity = 0.9;
            }
            if (!BtnDica10.IsEnabled)
            {
                BtnDica10.Background = wrong;
                BtnDica10.Opacity = 0.9;
            }
        }

        private int PontosMediador()
        {
            int aux = 0;
            if (!BtnDica1.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica2.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica3.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica4.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica5.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica6.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica7.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica8.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica9.IsEnabled)
            {
                aux++;
            }
            if (!BtnDica10.IsEnabled)
            {
                aux++;
            }
            return aux;
        }

        private void BtnErrado_Click(object sender, RoutedEventArgs e)
        {
            setWrong();
            JogarRodada();
            if(PontosMediador() == 10)
            {
                Negocio.NParticipante NParticipante = new Negocio.NParticipante();
                Modelo.Participante Mediador = NParticipante.GetMediador();
                NParticipante.UpdatePontos(Mediador.id, PontosMediador());
                if ((Mediador.placar + PontosMediador()) >= 20)
                {
                    Modelo.Participante.SetGanhador(Mediador.nome);
                    NavigationService.Navigate(new Uri("/PageVencedor.xaml", UriKind.Relative));
                }
                else
                {
                    NavigationService.Navigate(new Uri("/PageMediador.xaml", UriKind.Relative));
                }
            }
        }

        private void BtnCerto_Click(object sender, RoutedEventArgs e)
        {
            int pontos = PontosMediador();
            Negocio.NParticipante NParticipante = new Negocio.NParticipante();
            Modelo.Participante Mediador = NParticipante.GetMediador();
            Modelo.Participante JogadorVez = NParticipante.GetJogadorVez();       
            NParticipante.UpdatePontos(JogadorVez.id, 10 - pontos);
            if ((JogadorVez.placar + 10 - pontos) >= 20)
            {
                Modelo.Participante.SetGanhador(JogadorVez.nome);
                NavigationService.Navigate(new Uri("/PageVencedor.xaml", UriKind.Relative));
            }
            NParticipante.UpdatePontos(Mediador.id, pontos);
            if ((Mediador.placar + pontos) >= 20)
            {
                Modelo.Participante.SetGanhador(Mediador.nome);
                NavigationService.Navigate(new Uri("/PageVencedor.xaml", UriKind.Relative));
            }
            if((JogadorVez.placar + 10 - pontos) < 20 && (Mediador.placar + pontos < 20))
            {
                NavigationService.Navigate(new Uri("/PageMediador.xaml", UriKind.Relative));
            }
        }
    }
}
