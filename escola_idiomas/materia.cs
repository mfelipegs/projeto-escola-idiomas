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
    class materia : conexao
    {
        private int codigo;
        private string nome;
        private string cargahoraria;
        private int codcurso;

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setCargahoraria(string cargahoraria)
        {
            this.cargahoraria = cargahoraria;
        }
        public string getCargahoraria()
        {
            return this.cargahoraria;
        }

        public void setCodcurso(int codcurso)
        {
            this.codcurso = codcurso;
        }
        public int getCodcurso()
        {
            return codcurso;
        }

        public void inserir()
        {
            string query = "INSERT INTO materia(nome_materia,cargahoraria_materia,codigo_curso) VALUES('" +
                getNome() + "' , '" + getCargahoraria() + "' , '" + getCodcurso() + "')";
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

            string mSQL = "Select * from materia ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from materia where cod_materia = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
           
        }

        public void alterar()
        {
            string query = "UPDATE materia SET nome_materia ='" + getNome() + "', cargahoraria_materia = '" + getCargahoraria() + "' WHERE cod_materia = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
