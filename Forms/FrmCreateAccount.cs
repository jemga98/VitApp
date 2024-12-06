using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Runtime.InteropServices;
using VitApp_0._1._0.Clases;
using VitApp_0._1._0.Otros_forms.forms_cuestionarios;
using static VitApp_0._1._0.Classes.Userregistration;
using VitApp_0._1._0.Classes;
using VitApp_0._1._0.Models;
using VitApp_0._1._0.Dao;

namespace VitApp_0._1._0.Otros_forms
{
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoging formLogin = new FormLoging();
            formLogin.ShowDialog();
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Validations validation = new Validations();
            // Crear un objeto User con los datos necesarios
            User user = new User();

            string nombre = Tbname.Text;
            string lastNam = TbLastName.Text;
            DateTime fecha = DtpBirthDate.Value;
            string number = TbPhone.Text;
            string password = TbPassword.Text;

            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(lastNam) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("El número de teléfono debe ser positivo y tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Validar si el número de teléfono es positivo y tiene exactamente 8 dígitos
                else if (number.ToString().Length != 8)
                {
                    MessageBox.Show("Ningún campo puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Validar longitud de la contraseña
                else if (password.Length <= 4)
                {
                    MessageBox.Show("La contraseña debe tener entre 4 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Llamar al método de validación y guardado
                    bool isSaved = validation.SaveUserValidation(nombre, lastNam, fecha, number, password);

                    if (isSaved)
                    {
                        MessageBox.Show("Usuario guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirigir al formulario de inicio de sesión
                        FormLoging frmLogin = new FormLoging();
                        frmLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al guardar el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la validación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
           
            }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }


