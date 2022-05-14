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
    class turma : conexao
    {
        private int codigo;
        private int cod_curso;
        private int qtdvagas;

        public void setCod_curso(int cod_curso)
        {
            this.cod_curso = cod_curso;
        }
        public int getCod_curso()
        {
            return cod_curso;
        }

        public void setQtdvagas(int qtdvagas)
        {
            this.qtdvagas = qtdvagas;
        }
        public int getQtdvagas()
        {
            return qtdvagas;
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
            string query = "INSERT INTO turma(cod_curso,qtdvagas_turma) VALUES('" +
                getCod_curso() + "' , '" + getQtdvagas() + "')";
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

            string mSQL = "Select * from turma ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from turma where cod_turma = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE turma SET cod_curso ='" + getCod_curso() + "', qtdvagas_turma = '" + getQtdvagas() + "' WHERE cod_turma = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
