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

namespace CalcolatriceWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSomma_Click(object sender, RoutedEventArgs e)
        {
            if (txtnumero1.Text != "" && txtnumero2.Text != "")
            {
                try
                {
                    double primonum = double.Parse(txtnumero1.Text);
                    double secondonum = double.Parse(txtnumero2.Text);
                    lblrisultato.Content = primonum + secondonum;

                }
                catch (Exception)
                {
                    MessageBox.Show("numeri non validi", "Errato", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserisci dei numeri", "vuoto", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSottrazione_Click(object sender, RoutedEventArgs e)
        {
            if (txtnumero1.Text != "" && txtnumero2.Text != "")
            {
                try
                {
                    double primonum = double.Parse(txtnumero1.Text);
                    double secondonum = double.Parse(txtnumero2.Text);
                    lblrisultato.Content = primonum - secondonum;

                }
                catch (Exception)
                {
                    MessageBox.Show("numeri non validi", "Errato", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserisci dei numeri", "vuoto", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnMoltiplicazione_Click(object sender, RoutedEventArgs e)
        {
            if (txtnumero1.Text != "" && txtnumero2.Text != "")
            {
                try
                {
                    double primonum = double.Parse(txtnumero1.Text);
                    double secondonum = double.Parse(txtnumero2.Text);
                    lblrisultato.Content = primonum * secondonum;

                }
                catch (Exception)
                {
                    MessageBox.Show("numeri non validi", "Errato", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserisci dei numeri", "vuoto", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDivisione_Click(object sender, RoutedEventArgs e)
        {
            if (txtnumero1.Text != "" && txtnumero2.Text != "")
            {
                try
                {
                    double primonum = double.Parse(txtnumero1.Text);
                    double secondonum = double.Parse(txtnumero2.Text);
                    lblrisultato.Content = primonum / secondonum;

                }
                catch (Exception)
                {
                    MessageBox.Show("numeri non validi", "Errato", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Inserisci dei numeri", "vuoto", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
