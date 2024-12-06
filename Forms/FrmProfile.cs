using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitApp_0._1._0.Clases;
using VitApp_0._1._0.Classes;
using VitApp_0._1._0.Dao;
using VitApp_0._1._0.Otros_forms.Forms_Pantalla_principal;

namespace VitApp_0._1._0.Otros_forms
{
    public partial class FrmProfile : Form
    {
        private string userName;
        private string userPassword;

        User actualuser = new User();
        public FrmProfile(string name, string password)
        {
            InitializeComponent();
            userName = name;
            userPassword = password;
            ShowInfo();
        }

        public void ShowInfo()
        {
            bool isUserFound = UserSession.LoadUserData(userName, userPassword);

            if (isUserFound)
            {
                // Mostrar los datos en las etiquetas si se encontró el usuario
                LblName.Text = UserSession.Name;
                LblLastName.Text = UserSession.LastName;
            }
            else
            {
                MessageBox.Show("No se encontró al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProfile frmProfile = new FrmProfile(userName, userPassword);
            frmProfile.ShowDialog();
            this.Close();
        }

        private void Recomendantion_Click(object sender, EventArgs e)
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

        private void BtnProgress_Click_1(object sender, EventArgs e)
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


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
