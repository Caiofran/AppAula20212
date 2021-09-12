﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            this.Hide();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                User u = (User)formLogin.Tag;
                itbUsuarioLogado.Text = u.Usuario;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            itbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tHora.Enabled = true;
        }

        private void imSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brBtnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            form.ShowDialog();
        }
    }
}
