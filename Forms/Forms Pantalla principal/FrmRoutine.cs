﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitApp_0._1._0.Otros_forms.Forms_Pantalla_principal
{
    public partial class FrmRoutine : Form
    {
        public FrmRoutine()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmDiet frmDietas = new FrmDiet();
            frmDietas.ShowDialog();
            this.Close();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //PrincipalScreen principalScreen = new PrincipalScreen();
            //principalScreen.ShowDialog();
            //this.Close();
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProgress frmProgress = new FrmProgress();
            frmProgress.ShowDialog();
            this.Close();
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSetting frmConfiguration = new FrmSetting();
            frmConfiguration.ShowDialog();
            this.Close();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogOut frmSesion1 = new FrmLogOut();
            frmSesion1.ShowDialog();
            this.Close();
        }
    }
}