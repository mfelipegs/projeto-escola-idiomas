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
    public partial class frm_tarefa : Form
    {
        public frm_tarefa()
        {
            InitializeComponent();
        }

        tarefa ta = new tarefa();

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
            txt_codmateria.Text = "" + dataGridView1[2, i].Value;
            txt_dataentrega.Text = "" + dataGridView1[3, i].Value;
            txt_descricao.Text = "" + dataGridView1[4, i].Value;


        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro(dataGridView1.CurrentRow.Index);
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ta.Consultar();

            dataGridView1.Columns["codigo_tarefa"].HeaderText = "Código";
            dataGridView1.Columns["titulo_tarefa"].HeaderText = "Título";
            dataGridView1.Columns["codigo2_materia"].HeaderText = "Cod. Matéria";
            dataGridView1.Columns["dataentrega_tarefa"].HeaderText = "Data de Entrega";
            dataGridView1.Columns["descricao_tarefa"].HeaderText = "Descrição";
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ta.setTitulo(txt_titulo.Text);
                ta.setCodmateria(int.Parse(txt_codmateria.Text));
                ta.setDataentrega(txt_dataentrega.Text);
                ta.setDescricao(txt_descricao.Text);
                ta.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = ta.Consultar();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                ta.setCodigo(int.Parse(lbl_codigo.Text));
                ta.setTitulo(txt_titulo.Text);
                ta.setCodmateria(int.Parse(txt_codmateria.Text));
                ta.setDataentrega(txt_dataentrega.Text);
                ta.setDescricao(txt_descricao.Text);
                ta.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = ta.Consultar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                ta.setCodigo(int.Parse(lbl_codigo.Text));

                ta.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = ta.Consultar();
        }
    }
}
