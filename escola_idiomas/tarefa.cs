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
    class tarefa : conexao
    {
        private int codigo;
        private string titulo;
        private int codmateria;
        private string dataentrega;
        private string descricao;

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string getTitulo()
        {
            return this.titulo;
        }

        public void setCodmateria(int codmateria)
        {
            this.codmateria = codmateria;
        }
        public int getCodmateria()
        {
            return this.codmateria;
        }

        public void setDataentrega(string dataentrega)
        {
            this.dataentrega = dataentrega;
        }
        public string getDataentrega()
        {
            return this.dataentrega;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
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
            string query = "INSERT INTO tarefas(titulo_tarefa,codigo2_materia,dataentrega_tarefa,descricao_tarefa) VALUES('" +
                getTitulo() + "' , '" + getCodmateria() + "' , '" + getDataentrega() + "' , '" + getDescricao() + "')";
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

            string mSQL = "Select * from tarefas ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from tarefas where codigo_tarefa = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE tarefas SET titulo_tarefa ='" + getTitulo() + "', codigo2_materia = '" + getCodmateria() + "', dataentrega_tarefa = '" + getDataentrega() + "' WHERE codigo_tarefa = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
