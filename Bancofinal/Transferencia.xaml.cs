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

namespace Bancofinal
{
    /// <summary>
    /// Interaction logic for Transferencia.xaml
    /// </summary>
    public partial class Transferencia : Page
    {
        public Transferencia()
        {
            InitializeComponent();
        }

        private void OKtransf(object sender, RoutedEventArgs e)
        {
            confirmartransf l = new confirmartransf();
            this.Content = l;
        }

        private void Sairtransf(object sender, RoutedEventArgs e)
        {
            PaginaConta p = new PaginaConta();
            this.Content = p;
        }
    }
}
