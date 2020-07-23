using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancofinal
{
    class Persistencia
    {

        public Conta AchaConta(int numconta)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\dados\Banco\database.db;");
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM Conta WHERE Conta.id = @numconta", conn);
            com.Parameters.Add(new SQLiteParameter("@numconta", numconta));
            IDataReader reader = com.ExecuteReader();
            Conta c1 = null;
            while (reader.Read())
            {
                c1 = new Conta();
                c1.Id = Convert.ToInt32(reader["id"]);
                c1.Cliente_Id = Convert.ToInt32(reader["Cliente_id"]);
                c1.TipoConta = Convert.ToInt32(reader["Tipoconta_id"]);
                c1.Saldo = Convert.ToDouble(reader["Saldo"]);
            }
            conn.Close();
            return c1;
        }
    }
}
