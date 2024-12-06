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
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmProfile frmProfile = new FrmProfile();
            //frmProfile.ShowDialog();
            //this.Close();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRecomendation frmRecomendation = new FrmRecomendation();
            frmRecomendation.ShowDialog();
            this.Close();
        }

        private void BtnRutinas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRoutine frmRoutine = new FrmRoutine();
            frmRoutine.ShowDialog();
            this.Close();
        }

        private void BtnDIets_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmDiet frmDietas = new FrmDiet();
            frmDietas.ShowDialog();
            this.Close();
        }

        private void BtnProgress_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProgress frmProgress = new FrmProgress();
            frmProgress.ShowDialog();
            this.Close();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogOut frmSesion1 = new FrmLogOut();
            frmSesion1.ShowDialog();
            this.Close();
        }
    }
    
}
