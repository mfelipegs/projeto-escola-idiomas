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
    public partial class frm_escola : Form
    {
        public frm_escola()
        {
            InitializeComponent();
        }

        escola esc = new escola();

        public void exibiregistro(int i)
        {
            lbl_codigo.Text = "" + dataGridView1[0, i].Value;
            txt_nome.Text = "" + dataGridView1[1, i].Value;
            txt_endereco.Text = "" + dataGridView1[2, i].Value;
            txt_cep.Text = "" + dataGridView1[3, i].Value;
            
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro(dataGridView1.CurrentRow.Index);
        }

        private void Frm_escola_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = esc.Consultar();

            dataGridView1.Columns["codigo_escola"].HeaderText = "Código";
            dataGridView1.Columns["nome_escola"].HeaderText = "Nome";
            dataGridView1.Columns["endereco_escola"].HeaderText = "Endereço";
            dataGridView1.Columns["cep_escola"].HeaderText = "CEP";
        }

        private void Btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                esc.setNome(txt_nome.Text);
                esc.setEndereco(txt_endereco.Text);
                esc.setCep(txt_cep.Text);
                esc.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = esc.Consultar();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                esc.setCodigo(int.Parse(lbl_codigo.Text));

                esc.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = esc.Consultar();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                esc.setCodigo(int.Parse(lbl_codigo.Text));
                esc.setNome(txt_nome.Text);
                esc.setEndereco(txt_endereco.Text);
                esc.setCep(txt_cep.Text);
                esc.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = esc.Consultar();
        }
    }
}
