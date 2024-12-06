using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using VitApp_0._1._0.Clases;

namespace VitApp_0._1._0.Dao
{
    internal class UserSingleton
    {
        // Instancia única de la clase User
        private static User _instance;

        // Objeto para el control de concurrencia
        private static readonly object _lock = new object();

        // Constructor privado para evitar instanciación directa
        private UserSingleton() { }

        //acceder a la clase
        public static User Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new User();
                    }
                }
                return _instance;
            }
        }

        // Método opcional para reiniciar la instancia
        public static void ResetInstance()
        {
            lock (_lock)
            {
                _instance = null;
            }
        }
        public static void LoadFromBinaryFile(string filePath)
        {
            lock (_lock)
            {
                if (File.Exists(filePath))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        _instance = (User)formatter.Deserialize(stream);
                    }
                }
                else
                {
                    throw new FileNotFoundException("El archivo no existe.");
                }
            }
        }

    }
}
