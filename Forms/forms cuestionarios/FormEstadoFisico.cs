using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitApp_0._1._0.Models;

namespace VitApp_0._1._0.Otros_forms.forms_cuestionarios
{
    public partial class FormEstadoFisico : Form
    {
        public FormEstadoFisico()
        {
            InitializeComponent();
        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnAtrás_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            AssignPhysicStatus assignPhysicStatus = new AssignPhysicStatus();
            // Question 1
            if (Rbtn1Q1.Checked) assignPhysicStatus.Q1 = 1;
            else if (Rbtn1Q2.Checked) assignPhysicStatus.Q1 = 2;
            else if (Rbtn1Q3.Checked) assignPhysicStatus.Q1 = 3;
            else if (Rbtn1Q4.Checked) assignPhysicStatus.Q1 = 4;

            // Question 2
            if (Rbtn2Q1.Checked) assignPhysicStatus.Q2 = 1;
            else if (Rbtn2Q2.Checked) assignPhysicStatus.Q2 = 2;
            else if (Rbtn2Q3.Checked) assignPhysicStatus.Q2 = 3;

            // Question 3
            if (Rbtn3Q1.Checked) assignPhysicStatus.Q3 = 1;
            else if (Rbtn3Q2.Checked) assignPhysicStatus.Q3 = 2;
            else if (Rbtn3Q3.Checked) assignPhysicStatus.Q3 = 3;

            // Question 4
            if (Rbtn4Q1.Checked) assignPhysicStatus.Q4 = 1;
            else if (Rbtn4Q2.Checked) assignPhysicStatus.Q4 = 2;
            else if (Rbtn4Q3.Checked) assignPhysicStatus.Q4 = 3;
                       
            //assignPhysicStatus
            assignPhysicStatus.CalculateStatus();
            int pStatus = assignPhysicStatus.PStatus;

            this.Hide();
            //PrincipalScreen principalScreen = new PrincipalScreen();
            //principalScreen.ShowDialog();
            this.Close();
        }
    }
}
