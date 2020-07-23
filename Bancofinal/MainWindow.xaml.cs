using System;
using System.Windows;
using System.Data.SQLite;
using System.Data;

namespace Bancofinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PaginaConta pagConta;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persistencia per = new Persistencia();
            try
            {
                int j = Convert.ToInt32(numconta.Text);
                Conta c = per.AchaConta(j);
                if (c != null)
                {
                    pagConta = new PaginaConta();
                    pagConta.SetConta(c);
                    pagConta.Transf.Click += Button_Click_2;
                    pagConta.Saq.Click += Button_Click_0;
                    pagConta.Dep.Click += Button_Click_1;
                    this.Content = pagConta;
                }
                else
                    error.Text = "Conta inválida";
            }
            catch
            {
                error.Text = "Informe um valor";
            }
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Saque x = new Saque();
            x.oksaq.Click += OKsaq;
            x.sairsaq.Click += Sairsaq;
            this.Content = x;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            Deposito k = new Deposito();
            k.Okdep.Click += Okdep;
            k.Sairdep.Click += Sairdep;
            this.Content = k;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Transferencia y = new Transferencia();
            y.oktransf.Click += OKtransf;
            y.sairtrans.Click += Sairtransf;
            this.Content = y;
        }

        private void Okdep(object sender, RoutedEventArgs e)
        {
            //double valor = Convert.ToDouble(deposito.Text);
            //Conta.Dep(valor);

            confirmadeposito c = new confirmadeposito();
            c.acceptdep.Click += Accept_Click_dep;
            c.Canceldep.Click += Cancelar_Click_dep;
            this.Content = c;
        }

        private void Sairdep(object sender, RoutedEventArgs e)
        {
            this.Content = pagConta;
        }
        private void OKsaq(object sender, RoutedEventArgs e)
        {
            //double valor = Convert.ToDouble(saque.Text);
            //Conta.Saca(valor);

            confirmasaque j = new confirmasaque();
            j.Confsaq.Click += Confsaq_Click;
            j.Cancsaque.Click += Cancelarsaq_Click;
            this.Content = j;
        }



        private void Sairsaq(object sender, RoutedEventArgs e)
        {
            this.Content = pagConta;
        }


        private void OKtransf(object sender, RoutedEventArgs e)
        {
            confirmartransf l = new confirmartransf();
            l.conftransf.Click += Conftransf;
            l.Canctransf.Click += Canctransf;
            this.Content = l;
        }

        private void Sairtransf(object sender, RoutedEventArgs e)
        {
            this.Content = pagConta;
        }

        private void Cancelar_Click_dep(object sender, RoutedEventArgs e)
        {
            Deposito k = new Deposito();
            this.Content = k;
        }

        private void Accept_Click_dep(object sender, RoutedEventArgs e)
        {

        }
        private void Cancelarsaq_Click(object sender, RoutedEventArgs e)
        {
            Saque x = new Saque();
            this.Content = x;
        }

        private void Confsaq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Canctransf(object sender, RoutedEventArgs e)
        {
            Transferencia y = new Transferencia();
            this.Content = y;
        }

        private void Conftransf(object sender, RoutedEventArgs e)
        {

        }
    }

}



