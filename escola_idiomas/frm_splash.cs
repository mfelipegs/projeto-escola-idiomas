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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                frm_login form = new frm_login();
                form.Show();
                this.Hide();
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
