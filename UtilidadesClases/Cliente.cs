using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using UtilidadesGestionArchivo;
using System.Windows.Forms;

namespace UtilidadesClases
{
    public class Cliente : Persona
    {
        public static List<Cliente> ListaClientes;
        public static string path = "Files/Cliente.txt";
        public static string pathID = "Files/IDs/IdCliente.txt";

        public int IdCliente { get; set; }

        public static string[] Titles = { "ID", "Cedula", "Nombre", "Fecha Nacimiento", "Sexo", "Telefono", "Correo", "Direccion", "EstadoCivil" };

        public static int Index { get; set; }

        public static int Count { get; set; }

        public Cliente()
        {
            Count = ListaClientes.Count;

            GestionArchivo gs = new GestionArchivo(pathID);

            gs.CreateFile();
            string ID = gs.GetDateOne();

            if (ID != null)
            {
                IdCliente = Convert.ToInt32(ID);
                gs.Delete(IdCliente.ToString());
            }
            else
                IdCliente = ListaClientes.Count + 1;
        }
        
        public static Cliente StartList() { Index = 0; if (Count > 0) return ListaClientes.ElementAt(Index); return null; }
        public static Cliente EndList() { Index = ListaClientes.Count - 1; if ( Count > 0) return ListaClientes.ElementAt(Index); return null; }
        public static Cliente NextList() { Index += 1; if (Index < Count) return ListaClientes.ElementAt(Index); return EndList(); }
        public static Cliente BackList() { Index -= 1; if (Index >= 0) return ListaClientes.ElementAt(Index); return StartList(); }
        public override string ToString()
        {
            return (IdCliente.ToString() + "\t" + Cedula.ToString() + "\t" + Nombre + "\t" + FechaNacimiento.ToShortDateString() + "\t" +
                Sexo.ToString() + "\t" + Telefono.ToString() + "\t" + Correo + "\t" + Direccion + "\t" +
                EstadoCivil.ToString());
        }
        public void Add()
        {
            if (ListaClientes == null)
            {
                ListaClientes = new List<Cliente>();
            }

            ListaClientes.Add(this);
            this.Save();
        }

        public void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return $"{IdCliente},{Cedula},{Nombre},{FechaNacimiento.ToShortDateString()}," +
                $"{Sexo},{Telefono},{Correo},{Direccion},{EstadoCivil}";
        }

        public void Delete()
        {
            if (Find(this.IdCliente))
            {
                ListaClientes.Remove(this);
                GestionArchivo gs = new GestionArchivo(pathID);
                gs.Save(IdCliente.ToString());
            }
        }

        public static void Delete(object data)
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Delete(data);
        }
        public static void Edit(int linea, object data)
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Edit(linea, data);
        }

        public void Update()
        {
            Edit(ListaClientes.IndexOf(this), this);
        }

        public static void Update(Cliente c)
        {
            Edit(ListaClientes.IndexOf(c), c);
        }

        public static bool Find(int CodCliente)
        {
            foreach (Cliente Cliente in ListaClientes)
            {
                if (Cliente.IdCliente == CodCliente) return true;
            }
            return false;
        }

        public static bool Find(long CedCliente)
        {
            foreach (Cliente Cliente in ListaClientes)
            {
                if (Cliente.Cedula == CedCliente) return true;
            }
            return false;
        }

        public static Cliente SearchCed(long CedCliente)
        {
            foreach (Cliente v in ListaClientes)
            {
                if (v.Cedula == CedCliente)
                {
                    return v;
                }
            }
            return null;
        }

        public static Cliente SearchID(int IdCliente)
        {
            foreach (Cliente v in ListaClientes)
            {
                if (v.IdCliente == IdCliente)
                {
                    return v;
                }
            }
            return null;
        }

        public void SetItems(int i, string value)
        {
            switch (i)
            {
                case 0:
                    IdCliente = Convert.ToInt32(value);
                    break;
                case 1:
                    Cedula = Convert.ToInt64(value);
                    break;
                case 2:
                    Nombre = (string)value;
                    break;
                case 3:
                    FechaNacimiento = Convert.ToDateTime(value);
                    break;
                case 4:
                    Sexo = (Sexo)Sexo.Parse(typeof(Sexo), value.ToString());
                    break;
                case 5:
                    Telefono = Convert.ToInt64(value);
                    break;
                case 6:
                    Correo = (string)value;
                    break;
                case 7:
                    Direccion = (string)value;
                    break;
                case 8:
                    EstadoCivil = (EstadoCivil)EstadoCivil.Parse(typeof(EstadoCivil), value.ToString());
                    break;

            }
        }

        public static void LoadList()
        {
            ListaClientes = new List<Cliente>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');
                    Cliente v = new Cliente();

                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaClientes.Add(v);
                    
                }

                reader.Close();
            }
        }

    }
}
