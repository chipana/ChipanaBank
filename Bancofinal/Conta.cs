using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Diagnostics;

namespace Bancofinal
{
    public class Conta
    {
        public int Id { get; set; }
        public int Cliente_Id { get; set; }
        public int TipoConta { get; set; }
        public double Saldo { get; set; }
        public Cliente Cliente_Conta { get; set; }
        public TipoConta TipoConta_Tipo { get; set; }
        public void Saca(double valor)
        {
            if (Saldo < valor)
            {
            }
            else
                Saldo -= valor;
        }
        //public static void Transfere(Conta c1, Conta c2, double valor)
        //{
        //    if (valor > c1.saldo)
        //    {

        //    }
        //    else {
        //        c1.saldo -= valor;
        //        c2.saldo += valor;

        //    }


        //}

        public void Dep(double valor)
        {
            {
                Saldo += valor;
                Console.WriteLine("" + Saldo);


            }


        }
    }
    public enum TipoConta { Corrente = 1, Poupança };
}
