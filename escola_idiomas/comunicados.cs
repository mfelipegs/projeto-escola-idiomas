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
    class comunicados : conexao
    {
        private int codigo;
        private string titulo;
        private string texto;
        private string imagem;

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string getTitulo()
        {
            return this.titulo;
        }

        public void setTexto(string texto)
        {
            this.texto = texto;
        }
        public string getTexto()
        {
            return this.texto;
        }

        public void setImagem(string imagem)
        {
            this.imagem = imagem;
        }
        public string getImagem()
        {
            return this.imagem;
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
            string query = "INSERT INTO comunicados(titulo_comunicado,texto_comunicado,imagem_comunicado) VALUES('" +
                getTitulo() + "' , '" + getTexto() + "' , '" + getImagem() + "')";
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

            string mSQL = "Select * from comunicados ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from comunicados where codigo_comunicado = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE comunicados SET titulo_comunicado ='" + getTitulo() + "', texto_comunicado = '" + getTexto() + "', imagem_comunicado = '" + getImagem() + "' WHERE codigo_comunicado = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
