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

namespace ImcDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush SetColorEstadoNutricional(decimal imc)
        {
            if (imc < 18.5M)
            {
                return Brushes.Yellow;
            }
            else if (imc < 25.0M)
            {
                return Brushes.Green;
            }
            else if (imc < 30.0M)
            {
                return Brushes.Yellow;
            }
            else if (imc < 40.0M)
            {
                return Brushes.Orange;
            }
            else
            {
                return Brushes.Red;
            }
        }
            public MainWindow()
            {
                InitializeComponent();
            txtbxpeso.Focus();
        }


            private void btncalcular_Click(object sender, RoutedEventArgs e)
            {
                string s = txtbxpeso.Text;
                decimal peso = Convert.ToDecimal(s);
                s = txtbxestatura.Text;
                decimal estatura = Convert.ToDecimal(s);
                decimal imc = peso / (estatura * estatura);
                txtblocimc.Text = string.Format("{0:.0000}", imc);
                txtblocimc.Foreground = SetColorEstadoNutricional(imc);
                txtblocsituacion.Text = EstadoNutricional(imc);
                txtblocsituacion.Foreground = SetColorEstadoNutricional(imc);
                btnlimpiar.Focus();
            }

        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtbxpeso.Text = "";
            txtbxestatura.Text = "";
            txtblocimc.Text = "0.0";
            txtblocimc.Foreground = Brushes.Black;
            txtblocsituacion.Text = "";
            txtblocsituacion.Foreground = Brushes.Black;
            txtbxpeso.Focus();
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }
        private string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5M)
            {
                return "Peso bajo";
            }
            else if (imc < 25.0M)
            {
                return "Peso normal";
            }
            else if (imc < 30.0M)
            {
                return "Sobrepeso";
            }
            else if (imc < 40.0M)
            {
                return "Obesidad";
            }
            else
            {
                return "Obesidad extrema";
            }
        }
    }
        }