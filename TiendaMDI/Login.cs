using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UtilidadesGestionArchivo;

namespace TiendaMDI
{
    public class Login
    {
        public static List<Login> ListaUsers;
        public static string path = "Files/Login.txt";      
        public int CedulaVendedor { get; set; }
        public string User { get; set; }
        public string password { get; set; }

        public void Add()
        {
            if (ListaUsers == null)
            {
                ListaUsers = new List<Login>();
            }

            ListaUsers.Add(this);

            Save();
        }

        private void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return $"{CedulaVendedor},{User},{password}";
        }

        public override string ToString()
        {
            return (CedulaVendedor.ToString() + "\t" + User.ToString() + "\t" + password.ToString());
        }

        public static bool Find(int cedula)
        {
            foreach (Login v in ListaUsers)
            {
                if (v.CedulaVendedor == cedula) return true;
            }
            return false;
        }

        public static Login Search(int cedula)
        {
            foreach (Login v in ListaUsers)
            {
                if (v.CedulaVendedor == cedula)
                {
                    return v;
                }
            }
            return null;
        }

        public static Login Search(string usuario)
        {
            foreach (Login v in ListaUsers)
            {
                if (v.User == usuario)
                {
                    return v;
                }
            }
            return null;
        }

        public static Login SearchPass(string contraseña)
        {
            foreach (Login v in ListaUsers)
            {
                if (v.User == contraseña)
                {
                    return v;
                }
            }
            return null;
        }

        public void Delete()//Here
        {
            if (Find(this.CedulaVendedor))
            {
                ListaUsers.Remove(this);
                GestionArchivo gs = new GestionArchivo(path);
                gs.Save(CedulaVendedor.ToString());
            }
        }

        public static void Delete(object data)
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Delete(data);
        }

        public static void LoadList()
        {
            ListaUsers = new List<Login>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');

                    Login v = new Login();
                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaUsers.Add(v);

                }

                reader.Close();
            }
        }

        public void SetItems(int i, string value)
        {
            switch (i)
            {
                case 0:
                    CedulaVendedor = Convert.ToInt32(value);
                    break;
                case 1:
                    User = Convert.ToString(value);
                    break;
                case 2:
                    password = Convert.ToString(value);
                    break;
                
            }
        }
    }
}
