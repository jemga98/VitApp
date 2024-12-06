using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitApp_0._1._0.Clases;

namespace VitApp_0._1._0.Classes
{
    internal class Userregistration
    {
            private List<User> usuarios = new List<User>();
            private const string ArchivoDatos = "datos.dat";

            public void RegistrarUsuario(User usuario, Form formulario, bool SaveUser2 = false)
            {
                CargarDatosUsuarios();

                if (SaveUser2)
                {
                    // Buscar y actualizar el usuario existente
                    var usuarioExistente = usuarios.FirstOrDefault(u => u.Name == usuario.Name);
                    if (usuarioExistente != null)
                    {
                        int index = usuarios.IndexOf(usuarioExistente);
                        usuarios[index] = usuario;
                    }
                }
                else
                {
                    if (usuarios.Any(u => u.Name == usuario.Name))
                    {
                        MessageBox.Show(formulario, "El Usuario ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    usuarios.Add(usuario);
                }

                GuardarUsuarios();

            }

            public void CargarDatosUsuarios()
            {
                usuarios.Clear();

            if (File.Exists(ArchivoDatos))
            {
                return;

                FileStream File = new FileStream(ArchivoDatos, FileMode.Open, FileAccess.Read); ;
                BinaryReader reader = new BinaryReader(File);

                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    var usuario = new User
                    {
                        Name = reader.ReadString(),
                        LastName = reader.ReadString(),
                        BornDate = DateTime.Parse(reader.ReadString()),
                        Height = reader.ReadInt32(),
                        Weight = reader.ReadInt32(),
                        Phone = reader.ReadInt32(),
                        Password = reader.ReadString(),
                        PStatusUser = reader.ReadInt32()
                    };
                    usuarios.Add(usuario);
                }
            }
            }

            private void GuardarUsuarios()
            {
            File.Delete(ArchivoDatos);
            FileStream WriterFile = new FileStream(ArchivoDatos, FileMode.Create, FileAccess.Write);
            BinaryWriter Writer = new BinaryWriter(WriterFile);

            foreach (var usuario in usuarios)
                    {
                        Writer.Write(usuario.Name);
                        Writer.Write(usuario.LastName);
                        Writer.Write(usuario.BornDate.ToString("yyyy-MM-dd"));
                        Writer.Write(usuario.Height);
                        Writer.Write(usuario.Weight);
                        Writer.Write(usuario.Phone);
                        Writer.Write(usuario.Password);
                        Writer.Write(usuario.PStatusUser);
                    }
            Writer.Close();
        }

         
            public List<User> GetListaUsuarios()
            {
                return usuarios;
            }

            public void VerificarUsuario(string name, string contrasena, Form FrmLLogin )
            {
                CargarDatosUsuarios();

                if( name== "Name"  && contrasena== "Clave")
                {
                    MessageBox.Show(FrmLLogin, "Bienvenido Administrador.", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var usuario = usuarios.FirstOrDefault(u => u.Name.ToString() == name && u.Password == contrasena);

                if (usuario != null)
                {
                    MessageBox.Show(FrmLLogin, $"Bienvenido, {usuario.Name} {usuario.LastName}.", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(FrmLLogin, "Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }




    
