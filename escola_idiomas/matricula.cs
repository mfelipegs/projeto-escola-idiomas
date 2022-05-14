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
    class matricula : conexao
    {
        private int codigo;
        private int rm;
        private int codcurso;
        private string horarios;
        private string datainicio;
        private string datafim;
        private int codturma;
        private string nomealuno;
        private string rg;
        private string telefone;
        private string endereco;
        private string nomecurso;

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }

        public void setRm(int rm)
        {
            this.rm = rm;
        }
        public int getRm()
        {
            return this.rm;
        }

        public void setCodcurso(int codcurso)
        {
            this.codcurso = codcurso;
        }
        public int getCodcurso()
        {
            return codcurso;
        }

        public void setHorarios(string horarios)
        {
            this.horarios = horarios;
        }
        public string getHorarios()
        {
            return this.horarios;
        }

        public void setDatainicio(string datainicio)
        {
            this.datainicio = datainicio;
        }
        public string getDatainicio()
        {
            return this.datainicio;
        }

        public void setDatafim(string datafim)
        {
            this.datafim = datafim;
        }
        public string getDatafim()
        {
            return this.datafim;
        }

        public void setCodturma(int codturma)
        {
            this.codturma = codturma;
        }
        public int getCodturma()
        {
            return this.codturma;
        }

        public void setNomealuno(string nomealuno)
        {
            this.nomealuno = nomealuno;
        }
        public string getNomealuno()
        {
            return this.nomealuno;
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

        public void setNomecurso(string nomecurso)
        {
            this.nomecurso = nomecurso;
        }
        public string getNomecurso()
        {
            return this.nomecurso;
        }

        public void inserir()
        {
            string query = "INSERT INTO matricula(fk2_rm_aluno,fk2_cod_curso,horarios_matricula,datainicio_matricula,datafim_matricula,fk2_cod_turma,nome_aluno_mat,rg_aluno_mat,telefone_aluno_mat,endereco_aluno_mat,nome_curso_mat) VALUES('" +
                getRm() + "' , '" + getCodcurso() + "' , '" + getHorarios() + "' , '" + getDatainicio() + "' , '" + getDatafim() + "' , '" + getCodturma() + "' , '" + getNomealuno() + "' , '" + getRg() + "' , '" + getTelefone() + "' , '" + getEndereco() + "' , '" + getNomecurso() + "')";
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

            string mSQL = "Select * from matricula ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from matricula where codigo_matricula = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE matricula SET fk2_rm_aluno ='" + getRm() + "', fk2_cod_curso = '" + getCodcurso() + "', horarios_matricula = '" + getHorarios() + "', datainicio_matricula = '" + getDatainicio() + "', datafim_matricula = '" + getDatafim() + "', fk2_cod_turma = '" + getCodturma() + "', nome_aluno_mat = '" + getNomealuno() + "', rg_aluno_mat = '" + getRg() + "', telefone_aluno_mat = '" + getTelefone() + "', endereco_aluno_mat = '" + getEndereco() + "', nome_curso_mat = '" + getNomecurso() + "' WHERE codigo_matricula = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
