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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        home h = new home();

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

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

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = h.Consultar();

            dataGridView1.Columns["codigo_home"].HeaderText = "Código";
            dataGridView1.Columns["titulo_home"].HeaderText = "Título";
            dataGridView1.Columns["texto_home"].HeaderText = "Texto";
            dataGridView1.Columns["imagem_home"].HeaderText = "Imagem";

        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                h.setCodigo(int.Parse(lbl_codigo.Text));
                h.setTitulo(txt_titulo.Text);
                h.setTexto(txt_texto.Text);
                h.setImagem(txt_imagem.Text);
                h.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = h.Consultar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                h.setCodigo(int.Parse(lbl_codigo.Text));

                h.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = h.Consultar();
        }

        private void Btn_alterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                h.setCodigo(int.Parse(lbl_codigo.Text));
                h.setTitulo(txt_titulo.Text);
                h.setTexto(txt_texto.Text);
                h.setImagem(txt_imagem.Text);
                h.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = h.Consultar();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                h.setTitulo(txt_titulo.Text);
                h.setTexto(txt_texto.Text);
                h.setImagem(txt_imagem.Text);
                h.inserir();
            }

            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = h.Consultar();
        }

        private void Btn_excluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                h.setCodigo(int.Parse(lbl_codigo.Text));

                h.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = h.Consultar();
        }
    }
}
