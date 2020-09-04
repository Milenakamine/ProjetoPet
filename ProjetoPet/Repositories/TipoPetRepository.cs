using ProjetoPet.Context;
using ProjetoPet.Domains;
using ProjetoPet.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPet.Repositories
{
    public class TipoPetRepository : ITipoPet
    {
        //conectar com o banco com o context
        PetsContext conexao = new PetsContext();

        SqlCommand cmd = new SqlCommand();


        public TipoPet Alterar(TipoPet p)
        {
            //abre conexao
            cmd.Connection = conexao.Conectar();
            //metodos
            cmd.CommandText = "UPDATE TipoPet SET Descricao= @descricao WHERE IdTipoPet = @id";
            cmd.Parameters.AddWithValue("@descricao", p.Descricao);
            cmd.Parameters.AddWithValue("@id", p.IdTipoPet);
            //executta
            cmd.ExecuteNonQuery();

            //feha conexao
            conexao.Desconectar();
            //retorna
            return p;
        }

        public TipoPet BuscarPorId(int id)
        {
            //abre conexao
            cmd.Connection = conexao.Conectar();
            //metodo
            cmd.CommandText = "SELECT * FROM TipoPet WHERE IdTipoPet = @id";
            cmd.Parameters.AddWithValue("@id", id);
            //executa
            SqlDataReader dados = cmd.ExecuteReader();
            TipoPet pets = new TipoPet();

            while (dados.Read())
            {
                pets.IdTipoPet = Convert.ToInt32(dados.GetValue(0));
                pets.Descricao = dados.GetValue(1).ToString();
            }

            //fecha conexao
            conexao.Desconectar();
            return pets;
        }

        public TipoPet Cadastrar(TipoPet p)
        {
            //abre conexao
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "INSERT INTO TipoPet(Descricao)"+
                "VALUES" +
                "(@descricao)";
            cmd.Parameters.AddWithValue("@descricao", p.Descricao);

            //executa metodos
            cmd.ExecuteNonQuery();
            
            //fecha conexao
            conexao.Desconectar();

            return p;
        }


        public void Excluir(int id)
        {
            //abre conexao
            cmd.Connection = conexao.Conectar();

            //metodo
            cmd.CommandText = "DELETE FROM TipoPet WHERE IdTipoPet = @id";
            cmd.Parameters.AddWithValue("@id", id);

            //executa os metodos
            cmd.ExecuteNonQuery();

            //fecha conexao
            conexao.Desconectar();
        }



        public List<TipoPet> LerTodos()
        {
            //abre conexao 
            cmd.Connection = conexao.Conectar();

            //query
            cmd.CommandText = "SELECT *FROM TipoPet";

            SqlDataReader dados = cmd.ExecuteReader();

            //cria a lista para guardar tipopet
            List<TipoPet> pets = new List<TipoPet>();

            while (dados.Read())
            {
                pets.Add(
                    new TipoPet()
                    {
                        IdTipoPet = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString(),
                    }
                    );
            }
            //laço


            //fecha conexao 
            conexao.Desconectar();

            return pets;
        }
    }
}
