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
    /// Interaction logic for confirmasaque.xaml
    /// </summary>
    public partial class confirmasaque : Page
    {
        public confirmasaque()
        {
            InitializeComponent();
        }

        private void Cancelarsaq_Click(object sender, RoutedEventArgs e)
        {
            Saque x = new Saque();
            this.Content = x;
        }

        private void Confsaq_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
