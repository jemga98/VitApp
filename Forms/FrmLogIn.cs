using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using VitApp_0._1._0.Clases;
using VitApp_0._1._0.Classes;
using VitApp_0._1._0.Models;
using VitApp_0._1._0.Otros_forms;
using System.IO;
using static VitApp_0._1._0.Classes.Userregistration;

namespace VitApp_0._1._0
{
    public partial class FormLoging : Form
    {
        public FormLoging()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ShadowForm shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
            frmCreateAccount.ShowDialog();
            this.Close();
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string enteredName = TbUser.Text;
            string enteredPassword = TbUserPassword.Text;

            if (string.IsNullOrWhiteSpace(enteredName) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("El nombre y la contraseña no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isUserValid = ValidateUser(enteredName, enteredPassword);

            if (isUserValid)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Navegar a la siguiente pantalla
                PrincipalScreen frmMain = new PrincipalScreen(enteredName, enteredPassword);
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string name, string password)
        {
            string filePath = "user_data.txt";

            if (!File.Exists(filePath))
            {
                return false;
            }

            string[] lines = File.ReadAllLines(filePath);

            string savedName = "";
            string savedPassword = "";

            // Leer el archivo línea por línea
            foreach (string line in lines)
            {
                if (line.StartsWith("Name:"))
                {
                    savedName = line.Substring(5);  // Obtener el nombre guardado
                }
                if (line.StartsWith("Password:"))
                {
                    savedPassword = line.Substring(9);  // Obtener la contraseña guardada
                }

                // Comprobar si se encuentra el nombre y la contraseña correctos
                if (savedName == name && savedPassword == password)
                {
                    return true;
                }
            }

            return false;
        }

    }
}

