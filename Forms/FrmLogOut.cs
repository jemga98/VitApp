using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitApp_0._1._0.Otros_forms
{
    public partial class FrmLogOut : Form
    {
        public FrmLogOut()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogOut frmSesion = new FrmLogOut();
            frmSesion.ShowDialog();
            this.Close();
        }

        private void BtnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoging formLogin = new FormLoging();
            formLogin.ShowDialog();
            this.Close();
        }

        private void BtnAtrás_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //PrincipalScreen principalScreen = new PrincipalScreen();
            //principalScreen.ShowDialog();
            //this.Close();
        }
    }
}
