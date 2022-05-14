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
    public partial class frm_curso : Form
    {
        public frm_curso()
        {
            InitializeComponent();
        }

        curso c = new curso();
        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public void exibiregistro(int i)
        {
            lbl_codigo.Text = "" + dataGridView1[0, i].Value;
            txt_nome.Text = "" + dataGridView1[1, i].Value;
            txt_cargahoraria.Text = "" + dataGridView1[2, i].Value;
            txt_codescola.Text = "" + dataGridView1[3, i].Value;

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro(dataGridView1.CurrentRow.Index);
        }

        private void Frm_aluno_Load(object sender, EventArgs e)
        {

        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Txt_rg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNome(txt_nome.Text);
                c.setCargahoraria(txt_cargahoraria.Text);
                c.setCodescola(int.Parse(txt_codescola.Text));
                c.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = c.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();

            dataGridView1.Columns["codigo_curso"].HeaderText = "Código";
            dataGridView1.Columns["nome_curso"].HeaderText = "Nome";
            dataGridView1.Columns["cargahoraria_curso"].HeaderText = "Carga Horária";
            dataGridView1.Columns["codigo_escola"].HeaderText = "Cod. da Escola";
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(int.Parse(lbl_codigo.Text));
                c.setNome(txt_nome.Text);
                c.setCargahoraria(txt_cargahoraria.Text);
                c.setCodescola(int.Parse(txt_codescola.Text));
                c.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = c.Consultar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(int.Parse(lbl_codigo.Text));

                c.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = c.Consultar();
        }
    }
}
