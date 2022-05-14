using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; //Biblioteca de conexão do SQL.
using MySql.Data.MySqlClient; //Biblioteca de conexão do SQL.
using System.Data;

namespace escola_idiomas
{
    class escola : conexao
    {
        private int codigo;
        private string nome;
        private string endereco;
        private string cep;


        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }

        public void setCep(string cep)
        {
            this.cep = cep;
        }
        public string getCep()
        {
            return this.cep;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }


        public void inserir()
        {
            string query = "INSERT INTO escola(nome_escola,endereco_escola,cep_escola) VALUES('" +
                getNome() + "' , '" + getEndereco() + "' , '" + getCep() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable Consultar()
        {
            this.abrirconexao();

            string mSQL = "Select * from escola ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from escola where codigo_escola = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE escola SET nome_escola ='" + getNome() + "', endereco_escola = '" + getEndereco() + "', cep_escola = '" + getCep() + "' WHERE codigo_escola = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
