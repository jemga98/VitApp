using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitApp_0._1._0.Otros_forms.Forms_Pantalla_principal;

namespace VitApp_0._1._0.Otros_forms
{
    public partial class PrincipalScreen : Form
    {
        private string userName;
        private string userPassword;
        public PrincipalScreen(string user, string password)
        {
            InitializeComponent();
            userName = user;
            userPassword = password;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmDiet frmDietas = new FrmDiet();
            frmDietas.ShowDialog();
            this.Close();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogOut frmSesion1 = new FrmLogOut();
            frmSesion1.ShowDialog();
            this.Close();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSetting frmConfiguration = new FrmSetting();
            frmConfiguration.ShowDialog();
            this.Close();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProfile frmProfile = new FrmProfile(userName, userPassword);
            frmProfile.ShowDialog();
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
         this.Hide();
            FrmRoutine frmRoutine = new FrmRoutine();
            frmRoutine.ShowDialog();
            this.Close();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
        this.Hide();
            FrmProgress frmProgress = new FrmProgress();
            frmProgress.ShowDialog();
            this.Close();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRecomendation frmRecomendation = new FrmRecomendation();
            frmRecomendation.ShowDialog();
            this.Close();
        }
    }
}
