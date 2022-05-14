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
    public partial class frm_matricula : Form
    {
        public frm_matricula()
        {
            InitializeComponent();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        matricula m = new matricula();


        public void exibiregistro(int i)
        {
            lbl_codigo.Text = "" + dataGridView1[0, i].Value;
            txt_rm.Text = "" + dataGridView1[1, i].Value;
            txt_codcurso.Text = "" + dataGridView1[2, i].Value;
            txt_horarios.Text = "" + dataGridView1[3, i].Value;
            txt_datainicio.Text = "" + dataGridView1[4, i].Value;
            txt_datafinal.Text = "" + dataGridView1[5, i].Value;
            txt_codturma.Text = "" + dataGridView1[6, i].Value;
            txt_nomealuno.Text = "" + dataGridView1[7, i].Value;
            txt_rgaluno.Text = "" + dataGridView1[8, i].Value;
            txt_telefonealuno.Text = "" + dataGridView1[9, i].Value;
            txt_enderecoaluno.Text = "" + dataGridView1[10, i].Value;
            txt_nomecurso.Text = "" + dataGridView1[11, i].Value;
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
                m.setRm(int.Parse(txt_rm.Text));
                m.setCodcurso(int.Parse(txt_codcurso.Text));
                m.setHorarios(txt_horarios.Text);
                m.setDatainicio(txt_datainicio.Text);
                m.setDatafim(txt_datafinal.Text);
                m.setCodturma(int.Parse(txt_codturma.Text));
                m.setNomealuno(txt_nomealuno.Text);
                m.setRg(txt_rgaluno.Text);
                m.setTelefone(txt_telefonealuno.Text);
                m.setEndereco(txt_enderecoaluno.Text);
                m.setNomecurso(txt_nomecurso.Text);
                m.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = m.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m.Consultar();

            dataGridView1.Columns["codigo_matricula"].HeaderText = "Código";
            dataGridView1.Columns["fk2_rm_aluno"].HeaderText = "RM";
            dataGridView1.Columns["fk2_cod_curso"].HeaderText = "Cod. do Curso";
            dataGridView1.Columns["horarios_matricula"].HeaderText = "Horários";
            dataGridView1.Columns["datainicio_matricula"].HeaderText = "Data Início";
            dataGridView1.Columns["datafim_matricula"].HeaderText = "Data Fim";
            dataGridView1.Columns["fk2_cod_turma"].HeaderText = "Cod. da Turma";
            dataGridView1.Columns["nome_aluno_mat"].HeaderText = "Nome do Aluno";
            dataGridView1.Columns["rg_aluno_mat"].HeaderText = "RG";
            dataGridView1.Columns["telefone_aluno_mat"].HeaderText = "Telefone";
            dataGridView1.Columns["endereco_aluno_mat"].HeaderText = "Endereço";
            dataGridView1.Columns["nome_curso_mat"].HeaderText = "Nome do Curso";
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                m.setCodigo(int.Parse(lbl_codigo.Text));

                m.excluir();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso.");
            }
            dataGridView1.DataSource = m.Consultar();
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                m.setCodigo(int.Parse(lbl_codigo.Text));
                m.setRm(int.Parse(txt_rm.Text));
                m.setCodcurso(int.Parse(txt_codcurso.Text));
                m.setHorarios(txt_horarios.Text);
                m.setDatainicio(txt_datainicio.Text);
                m.setDatafim(txt_datafinal.Text);
                m.setCodturma(int.Parse(txt_codturma.Text));
                m.setNomealuno(txt_nomealuno.Text);
                m.setRg(txt_rgaluno.Text);
                m.setTelefone(txt_telefonealuno.Text);
                m.setEndereco(txt_enderecoaluno.Text);
                m.setNomecurso(txt_nomecurso.Text);
                m.alterar();
            }

            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.DataSource = m.Consultar();
        }
    }
}
