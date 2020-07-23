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
    /// Interaction logic for paginaconta.xaml
    /// </summary>
    public partial class PaginaConta : Page
    {
        Conta conta;
        public PaginaConta()
        {
            InitializeComponent();
        }
        public void SetConta(Conta conta)
        {
            this.conta = conta;
            //header.Text = "" + conta.Cliente_Conta.Nome;
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
