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
    public partial class frm_professor : Form
    {
        public frm_professor()
        {
            InitializeComponent();
        }
        professor pro = new professor();

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
            txt_telefone.Text = "" + dataGridView1[2, i].Value;
            txt_endereco.Text = "" + dataGridView1[3, i].Value;

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
                pro.setNome(txt_nome.Text);
                pro.setTelefone(txt_telefone.Text);
                pro.setEndereco(txt_endereco.Text);
                pro.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = pro.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pro.Consultar();

            dataGridView1.Columns["codigo_professor"].HeaderText = "Código";
            dataGridView1.Columns["nome_professor"].HeaderText = "Nome";
            dataGridView1.Columns["telefone_professor"].HeaderText = "Telefone";
            dataGridView1.Columns["endereco_professor"].HeaderText = "Endereço";
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                pro.setCodigo(int.Parse(lbl_codigo.Text));
                pro.setNome(txt_nome.Text);
                pro.setTelefone(txt_telefone.Text);
                pro.setEndereco(txt_endereco.Text);
                pro.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = pro.Consultar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                pro.setCodigo(int.Parse(lbl_codigo.Text));

                pro.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = pro.Consultar();
        }
    }
}
