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
using VitApp_0._1._0.Clases;
using VitApp_0._1._0.Classes;
using VitApp_0._1._0.Dao;
using VitApp_0._1._0.Models;

namespace VitApp_0._1._0.Otros_forms.forms_cuestionarios
{
    public partial class FrmTest1 : Form
    {
        

        public FrmTest1()
        {
            InitializeComponent();
            
        }

        
        private void BtnNext_Click(object sender, EventArgs e)
        {
            User user = UserSingleton.Instance;

            string filePath = "userData.bin";
            
            AssignPhysicStatus assignPhysicStatus= new AssignPhysicStatus();
            if (Btncalories1.Checked)
            {
                assignPhysicStatus.Calories = 4;
            }
            else if (Btncalories2.Checked)
            {
                assignPhysicStatus.Calories = 3;
            }
            else if (Btncalories3.Checked)
            {
                assignPhysicStatus.Calories = 2;
            }
            else if (Btncalories4.Checked) // Este condicional parece duplicado; deberías usar otro botón o corregir el nombre.
            {
                assignPhysicStatus.Calories = 1;
            }
            else
            {
                // Si ningún botón está seleccionado, mostrar un mensaje de error.
                MessageBox.Show("Debe seleccionar una opción de calorías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Userregistration.SaveUser1(user, filePath);
            this.Hide();
            FormEstadoFisico formEstadoFisico = new FormEstadoFisico();
            formEstadoFisico.ShowDialog();
            this.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
            frmCreateAccount.ShowDialog();
            this.Close();
        }
    }
}
