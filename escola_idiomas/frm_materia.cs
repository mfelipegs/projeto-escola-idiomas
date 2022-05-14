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
    public partial class frm_materia : Form
    {
        public frm_materia()
        {
            InitializeComponent();
        }
        materia mat = new materia();

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
            txt_codcurso.Text = "" + dataGridView1[3, i].Value;
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
                
                mat.setNome(txt_nome.Text);
                mat.setCargahoraria(txt_cargahoraria.Text);
                mat.setCodcurso(int.Parse(txt_codcurso.Text));
                
                mat.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }

            dataGridView1.DataSource = mat.Consultar();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mat.Consultar();

            dataGridView1.Columns["cod_materia"].HeaderText = "Código";
            dataGridView1.Columns["nome_materia"].HeaderText = "Nome";
            dataGridView1.Columns["cargahoraria_materia"].HeaderText = "Carga Horária";
            dataGridView1.Columns["codigo_curso"].HeaderText = "Cod. do Curso";

        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Código do EXCLUIR
            try
            {
                mat.setCodigo(int.Parse(lbl_codigo.Text));
                
                mat.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = mat.Consultar();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                mat.setCodigo(int.Parse(lbl_codigo.Text));
                mat.setNome(txt_nome.Text);
                mat.setCargahoraria(txt_cargahoraria.Text);
                mat.setCodcurso(int.Parse(txt_codcurso.Text));
                mat.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = mat.Consultar();
        }
    }
}
