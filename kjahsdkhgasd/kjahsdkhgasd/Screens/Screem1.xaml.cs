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

namespace kjahsdkhgasd.Screens
{
    /// <summary>
    /// Lógica de interacción para Screem1.xaml
    /// </summary>
    public partial class Screem1 : Page
    {
        public Screem1()
        {
            InitializeComponent();
        }
        public class Registro
        {
            public string CodProd { get; set; }
            public string NomProd { get; set; }
            public string PrecProd { get; set; }
            public string MedProd { get; set; }
            public string CantProd { get; set; }
            public double Multi(double n1, double n2)
            {
                double n3 = (n1 * n2);
                return (n3);
            }
            public string Multi1 { get; set; }
        }

        private void BG_Click(object sender, RoutedEventArgs e)
        {
            Registro RG = new Registro();
            double aux1 = Convert.ToDouble(T4.Text);
            double aux2 = Convert.ToDouble(T3.Text);
            double R = RG.Multi(aux1, aux2);//almacena la operacion de multi en R
            RG.NomProd = T0.Text;
            RG.CodProd = T1.Text;
            RG.MedProd = T2.Text;
            RG.CantProd = T3.Text;
            RG.PrecProd = T4.Text;
            RG.Multi1 = "" + R;//muestra el resultado en total en RG
            DTG1.Items.Add(RG);//agrega los registros
        }

        private void BL_Click(object sender, RoutedEventArgs e)
        {
            T0.Text = "";
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            T4.Text = "";
        }

        private void BS_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana principal o salir de la aplicación completa
            Application.Current.Shutdown();
        }

        private void T0_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
    
