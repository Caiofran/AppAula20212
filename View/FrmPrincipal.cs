using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            FrmLogin form = new FrmLogin();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;

            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você apertou no botão ok");
            FrmCadPessoa form = new FrmCadPessoa();

            //this.Visible = false;

            //form.Show();
            form.ShowDialog();

            //this.Visible = true;

            //MessageBox.Show("passou!!");
        }

        /*private void MensagemNaTela(object sender, EventArgs e)
        {
            int a = 2;
            int b = 3;
            int res = a + b;
            MessageBox.Show("Resutado " + res);
        }*/

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

    }
}
