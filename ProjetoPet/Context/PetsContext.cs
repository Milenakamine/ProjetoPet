using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPet.Context
{
    public class PetsContext
    {

        SqlConnection con = new SqlConnection();

        public PetsContext()
        {
            con.ConnectionString = @"Data Source=LAB107401\SQLEXPRESS;Initial Catalog=PetShop;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }





    }
}
