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

namespace IntroductionToCryptography
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

        private void CryptoAlgorithms_Click(object sender, RoutedEventArgs e)
        {
            CryptoAlgorithms CryptoAlgorithmsObject = new CryptoAlgorithms();
            CryptoAlgorithmsObject.Show();
        }

        private void RSA_Click(object sender, RoutedEventArgs e)
        {
            Algorithms AlgorithmsObject = new Algorithms();
            AlgorithmsObject.Show();
        }

        private void StreamCiphers_Click(object sender, RoutedEventArgs e)
        {
            StreamCiphers StreamCiphersObject = new StreamCiphers();
            StreamCiphersObject.Show();
        }

        private void BlockCiphers_Click(object sender, RoutedEventArgs e)
        {
            BlockCiphers BlockCiphersObject = new BlockCiphers();
            BlockCiphersObject.Show();

        }

   
    }
}
