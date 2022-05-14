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
    public partial class frm_aluno : Form
    {
        public frm_aluno()
        {
            InitializeComponent();
        }

        aluno a = new aluno();

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public void exibiregistro(int i)
        {
            lbl_rm.Text = "" + dataGridView1[0, i].Value;
            txt_nome.Text = "" + dataGridView1[1, i].Value;
            txt_rg.Text = "" + dataGridView1[2, i].Value;
            txt_telefone.Text = "" + dataGridView1[3, i].Value;
            txt_endereco.Text = "" + dataGridView1[4, i].Value;
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
                a.setNome(txt_nome.Text);
                a.setRg(txt_rg.Text);
                a.setTelefone(txt_telefone.Text);
                a.setEndereco(txt_endereco.Text);
                a.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = a.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();

            dataGridView1.Columns["rm_aluno"].HeaderText = "RM";
            dataGridView1.Columns["nome_aluno"].HeaderText = "Nome";
            dataGridView1.Columns["rg_aluno"].HeaderText = "RG";
            dataGridView1.Columns["telefone_aluno"].HeaderText = "Telefone";
            dataGridView1.Columns["endereco_aluno"].HeaderText = "Endereço";
            
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    a.setRm(int.Parse(lbl_rm.Text));
                    a.setNome(txt_nome.Text);
                    a.setRg(txt_rg.Text);
                    a.setTelefone(txt_telefone.Text);
                    a.setEndereco(txt_endereco.Text);
                    a.alterar();
                }

                finally
                {
                    MessageBox.Show("Informações alteradas com sucesso");
                }
                dataGridView1.DataSource = a.Consultar();
            
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                a.setRm(int.Parse(lbl_rm.Text));

                a.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = a.Consultar();
        }
    }
}
