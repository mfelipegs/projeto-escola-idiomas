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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_escola form = new frm_escola();
            form.Show();
            this.Hide();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login form = new frm_login();
            form.Show();
            this.Hide();
        }

        private void AlunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_aluno form = new frm_aluno();
            form.Show();
            this.Hide();
        }

        private void CursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_curso form = new frm_curso();
            form.Show();
            this.Hide();
        }

        private void MatériaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_materia form = new frm_materia();
            form.Show();
            this.Hide();
        }

        private void ProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_professor form = new frm_professor();
            form.Show();
            this.Hide();
        }

        private void TurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_turma form = new frm_turma();
            form.Show();
            this.Hide();
        }

        private void ClasseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_classe form = new frm_classe();
            form.Show();
            this.Hide();
        }

        private void MatrículaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_matricula form = new frm_matricula();
            form.Show();
            this.Hide();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_aluno form = new frm_aluno();
            form.Show();
            this.Hide();
        }

        private void CursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_curso form = new frm_curso();
            form.Show();
            this.Hide();
        }

        private void MatériaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_materia form = new frm_materia();
            form.Show();
            this.Hide();
        }

        private void EscolaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_escola form = new frm_escola();
            form.Show();
            this.Hide();
        }

        private void ProfessorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_professor form = new frm_professor();
            form.Show();
            this.Hide();
        }

        private void TurmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_turma form = new frm_turma();
            form.Show();
            this.Hide();
        }

        private void ClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_classe form = new frm_classe();
            form.Show();
            this.Hide();
        }

        private void MatrículaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frm_matricula form = new frm_matricula();
            form.Show();
            this.Hide();
        }

        private void TarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tarefa form = new frm_tarefa();
            form.Show();
            this.Hide();
        }

        private void ComunicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_comunicados form = new frm_comunicados();
            form.Show();
            this.Hide();
        }

        private void HomemobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_home form = new frm_home();
            form.Show();
            this.Hide();
        }

        private void ConteúdomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_conteudo form = new frm_conteudo();
            form.Show();
            this.Hide();
        }
    }
}
