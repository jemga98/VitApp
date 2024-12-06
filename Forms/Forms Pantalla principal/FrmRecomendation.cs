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

namespace VitApp_0._1._0.Otros_forms.Forms_Pantalla_principal
{
    public partial class FrmRecomendation : Form
    {
        // Ruta relativa al archivo en la carpeta Resources
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Recomendaciones (1).txt");

        public FrmRecomendation()
        {
            InitializeComponent();
            LoadRecommendations();
        }

        private void LoadRecommendations()
        {
            // Verifica si el archivo existe
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Recomendaciones (1).txt");

            // Verifica si el archivo existe
            if (File.Exists(filePath))
            {
                try
                {
                    // Lee todas las líneas del archivo
                    string[] recommendations = File.ReadAllLines(filePath);

                    // Verifica que haya suficientes recomendaciones
                    if (recommendations.Length < 4)
                    {
                        MessageBox.Show("El archivo debe contener al menos 4 recomendaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Barajar las recomendaciones
                    Random random = new Random();
                    var randomRecommendations = recommendations.OrderBy(x => random.Next()).Take(4).ToArray();

                    // Asigna las líneas aleatorias a los labels
                    LblRecomendation1.Text = randomRecommendations.Length > 0 ? randomRecommendations[0] : "No hay recomendación 1.";
                    LblRecomendation2.Text = randomRecommendations.Length > 1 ? randomRecommendations[1] : "No hay recomendación 2.";
                    LblRecomendation3.Text = randomRecommendations.Length > 2 ? randomRecommendations[2] : "No hay recomendación 3.";
                    LblRecomendation4.Text = randomRecommendations.Length > 3 ? randomRecommendations[3] : "No hay recomendación 4.";
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el archivo no existe
                MessageBox.Show("El archivo 'Recomendaciones (1).txt' no existe en la carpeta Resources. Asegúrate de agregarlo.",
                                "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRoutine frmRoutine = new FrmRoutine();
            frmRoutine.ShowDialog();
            this.Close();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDiet frmDietas = new FrmDiet();
            frmDietas.ShowDialog();
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