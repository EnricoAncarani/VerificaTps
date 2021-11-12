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

namespace VerificaTPS
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca x;
        public MainWindow()
        {
            InitializeComponent();
            x = new Biblioteca();
        }

        private void AggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro x = new Libro(TxtNome.Text, TXTtitolo.Text, TxtData.Text, TxtEditor.Text, int.Parse(TXTnumeroPagine.Text));
            x.AggiungiLibro(x);
        }
    }
}
