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
    class classe : conexao
    {
        private int codprof;
        private int codturma;

        public void setCodprof(int codprof)
        {
            this.codprof = codprof;
        }
        public int getCodprof()
        {
            return this.codprof;
        }

        public void setCodturma(int codturma)
        {
            this.codturma = codturma;
        }
        public int getCodturma()
        {
            return this.codturma;
        }

        public void inserir()
        {
            string query = "INSERT INTO classe(fk_cod_professor,fk_cod_turma) VALUES('" +
                getCodprof() + "' , '" + getCodturma() + "')";
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

            string mSQL = "Select * from classe ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
