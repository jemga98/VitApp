using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitApp_0._1._0.Clases;
using VitApp_0._1._0.Classes;
using VitApp_0._1._0.Dao;

public class Validations
{
    public bool SaveUserValidation(string nombre, string lastNam, DateTime fecha, string number, string password)
    {
        try
        {
            // Crear el objeto User con los datos proporcionados
            User user = new User
            {
                Name = nombre,
                LastName = lastNam,
                BornDate = fecha,
                Phone = Convert.ToInt32(number),
                Password = password
            };

            string filePath = "user_data.txt";  // Ruta del archivo donde guardar los datos

            // Verificamos si el archivo existe; si no, lo creamos
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Name:{user.Name}");
                writer.WriteLine($"LastName:{user.LastName}");
                writer.WriteLine($"BirthDate:{user.BornDate.ToShortDateString()}");
                writer.WriteLine($"Phone:{user.Phone}");
                writer.WriteLine($"Password:{user.Password}");
                writer.WriteLine("---");
            }

            return true; // Indicar que la inserción fue exitosa
        }
        catch (Exception ex)
        {
            // Si ocurre algún error, mostrar el mensaje en la consola (o puedes loguearlo)
            Console.WriteLine($"Error al guardar el usuario: {ex.Message}");
            return false; // Indicar que hubo un error
        }
    }

    //public bool PhysicValidations(User user)
    //{
    //    // Validar peso
    //    if (user.Weight < 45 || user.Weight > 200)
    //    {
    //        MessageBox.Show("El peso debe estar entre 45 y 200 kilos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //        return false;
    //    }

    //    // Validar altura
    //    if (user.Height < 140 || user.Height > 250)
    //    {
    //        MessageBox.Show("La altura debe estar entre 140 y 250 centímetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //        return false;
    //    }

    //    // Validaciones adicionales de valores negativos
    //    if (user.Weight <= 0 || user.Height <= 0)
    //    {
    //        MessageBox.Show("El peso y la altura deben ser valores positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //        return false;
    //    }

    //    return true;
    //}
}
