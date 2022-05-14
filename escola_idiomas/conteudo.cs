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
    class conteudo : conexao
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
            string query = "INSERT INTO conteudo(titulo_conteudo,texto_conteudo,imagem_conteudo) VALUES('" +
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

            string mSQL = "Select * from conteudo ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void excluir()
        {
            string query = "Delete from conteudo where codigo_conteudo = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void alterar()
        {
            string query = "UPDATE conteudo SET titulo_conteudo ='" + getTitulo() + "', texto_conteudo = '" + getTexto() + "', imagem_conteudo = '" + getImagem() + "' WHERE codigo_conteudo = '" + getCodigo() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}
