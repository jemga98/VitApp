using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitApp_0._1._0.Clases;
using System.IO;

namespace VitApp_0._1._0.Dao
{
    public static class UserSession
    {
        public static string Name { get; set; }
        public static string LastName { get; set; }
        public static string Password { get; set; }
        public static DateTime BirthDate { get; set; }
        public static int Phone { get; set; }

        // Método para cargar los datos del usuario desde el archivo
        public static bool LoadUserData(string name, string password)
        {
            string filePath = "user_data.txt";

            if (!File.Exists(filePath))
            {
                return false;  // Si el archivo no existe, no podemos encontrar el usuario
            }

            string[] lines = File.ReadAllLines(filePath);
            string savedName = "";
            string savedLastName = "";
            string savedPassword = "";
            DateTime savedBirthDate = DateTime.MinValue;
            int savedPhone = 0;

            // Leer el archivo línea por línea
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (line.StartsWith("Name:"))
                {
                    savedName = line.Substring(5).Trim();
                }
                else if (line.StartsWith("LastName:"))
                {
                    savedLastName = line.Substring(9).Trim();
                }
                else if (line.StartsWith("Password:"))
                {
                    savedPassword = line.Substring(9).Trim();
                }
                else if (line.StartsWith("BirthDate:"))
                {
                    DateTime.TryParse(line.Substring(10).Trim(), out savedBirthDate);
                }
                else if (line.StartsWith("Phone:"))
                {
                    int.TryParse(line.Substring(6).Trim(), out savedPhone);
                }

                // Comprobar si se encontró un usuario que coincida con el nombre y la contraseña
                if (savedName == name && savedPassword == password)
                {
                    // Si el usuario se encuentra, guardar los datos en las propiedades estáticas
                    Name = savedName;
                    LastName = savedLastName;
                    Password = savedPassword;
                    BirthDate = savedBirthDate;
                    Phone = savedPhone;

                    return true;  // Usuario encontrado
                }
            }

            return false;  // No se encontró el usuario
        }

    }
}
