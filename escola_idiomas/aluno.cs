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
    class aluno : conexao
    {
        private int rm;
        private string nome;
        private string rg;
        private string telefone;
        private string endereco;


        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getRg()
        {
            return this.rg;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return this.telefone;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }

        public void setRm(int rm)
        {
            this.rm = rm;
        }
        public int getRm()
        {
            return this.rm;
        }

        public void inserir()
        {
            string query = "INSERT INTO aluno(nome_aluno,rg_aluno,telefone_aluno,endereco_aluno) VALUES('" +
                getNome() + "' , '" + getRg() + "' , '" + getTelefone() + "' , '" + getEndereco() + "')";
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

            string mSQL = "Select * from aluno ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from aluno where rm_aluno = '" + getRm() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE aluno SET nome_aluno ='" + getNome() + "', rg_aluno = '" + getRg() + "', telefone_aluno = '" + getTelefone() + "', endereco_aluno = '" + getEndereco() + "' WHERE rm_aluno = '" + getRm() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
