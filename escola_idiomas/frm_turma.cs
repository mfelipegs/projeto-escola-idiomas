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
    public partial class frm_turma : Form
    {
        public frm_turma()
        {
            InitializeComponent();
        }

        turma tu = new turma();

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public void exibiregistro(int i)
        {
            lbl_codigo.Text = "" + dataGridView1[0, i].Value;
            txt_codcurso.Text = "" + dataGridView1[1, i].Value;
            txt_qtdvagas.Text = "" + dataGridView1[2, i].Value;

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
                tu.setCod_curso(int.Parse(txt_codcurso.Text));
                tu.setQtdvagas(int.Parse(txt_qtdvagas.Text));
                tu.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = tu.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tu.Consultar();

            dataGridView1.Columns["cod_turma"].HeaderText = "Cod. da turma";
            dataGridView1.Columns["cod_curso"].HeaderText = "Cod. do Curso";
            dataGridView1.Columns["qtdvagas_turma"].HeaderText = "Qtd. de Vagas";
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                tu.setCodigo(int.Parse(lbl_codigo.Text));
                tu.setCod_curso(int.Parse(txt_codcurso.Text));
                tu.setQtdvagas(int.Parse(txt_qtdvagas.Text));
                tu.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = tu.Consultar();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                tu.setCodigo(int.Parse(lbl_codigo.Text));

                tu.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = tu.Consultar();
        }
    }
}
