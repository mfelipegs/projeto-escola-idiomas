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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_senha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_usuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Click(object sender, EventArgs e)

        {

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair?", "Escola de Idiomas",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void Btn_acessar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "admin" && txt_senha.Text == "admin")
            {
                Form1 formulario = new Form1();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e Senha inválidos", "Acesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
