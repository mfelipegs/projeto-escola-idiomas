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
    public partial class frm_classe : Form
    {
        public frm_classe()
        {
            InitializeComponent();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public void exibiregistro(int i)
        {
            txt_codprof.Text = "" + dataGridView1[0, i].Value;
            txt_codturma.Text = "" + dataGridView1[1, i].Value;

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro(dataGridView1.CurrentRow.Index);
        }

        classe cl = new classe();

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
                cl.setCodprof(int.Parse(txt_codprof.Text));
                cl.setCodturma(int.Parse(txt_codturma.Text));
                cl.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso.");
            }
            dataGridView1.DataSource = cl.Consultar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cl.Consultar();

            dataGridView1.Columns["fk_cod_professor"].HeaderText = "Cod. do Professor";
            dataGridView1.Columns["fk_cod_turma"].HeaderText = "Cod. da Turma";
        }
    }
}
