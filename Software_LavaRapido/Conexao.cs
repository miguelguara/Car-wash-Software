using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Software_LavaRapido
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao() 
        {
            banco = new SqlConnection("Server=LAPTOP-ODRTVVDN\\SQLSERVER2022;Database=LavaRapido;Trusted_Connection=True;");
        }
    }
}
