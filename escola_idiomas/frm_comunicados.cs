using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escola_idiomas
{
    public partial class frm_comunicados : Form
    {
        public frm_comunicados()
        {
            InitializeComponent();
        }

        comunicados com = new comunicados();

        public void exibiregistro(int i)
        {
            lbl_codigo.Text = "" + dataGridView1[0, i].Value;
            txt_titulo.Text = "" + dataGridView1[1, i].Value;
            txt_texto.Text = "" + dataGridView1[2, i].Value;
            txt_imagem.Text = "" + dataGridView1[3, i].Value;

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro(dataGridView1.CurrentRow.Index);
        }


        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                com.setTitulo(txt_titulo.Text);
                com.setTexto(txt_texto.Text);
                com.setImagem(txt_imagem.Text);
                com.inserir();
            }

            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = com.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = com.Consultar();

            dataGridView1.Columns["codigo_comunicado"].HeaderText = "Código";
            dataGridView1.Columns["titulo_comunicado"].HeaderText = "Título";
            dataGridView1.Columns["texto_comunicado"].HeaderText = "Texto";
            dataGridView1.Columns["imagem_comunicado"].HeaderText = "Imagem";
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                com.setCodigo(int.Parse(lbl_codigo.Text));
                com.setTitulo(txt_titulo.Text);
                com.setTexto(txt_texto.Text);
                com.setImagem(txt_imagem.Text);
                com.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = com.Consultar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
               com.setCodigo(int.Parse(lbl_codigo.Text));

                com.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = com.Consultar();
        }
    }
}
