using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using UtilidadesGestionArchivo;

namespace UtilidadesClases
{
    public class Vendedor : Persona
    {

        public static List<Vendedor> ListaVendedores;
        public static string path = "Files/Vendedor.txt";
        public static string pathID = "Files/IDs/IdVendedor.txt";
        public static string[] Titles = { "ID", "Cedula", "Nombre", "Fecha Nacimiento", "Sexo", "Telefono", "Correo", "Direccion", "EstadoCivil", "Fecha Ingreso", "Salario", "Profesión", "Calificación" };

        public int IdVendedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Salario { get; set; }
        public string Profesion { get; set; }
        public int Calificacion { get; set; }
 
        
        public static int Index { get; set; }
        public static int Count { get; set; }

        public Vendedor()
        {
            Count = ListaVendedores.Count;

            GestionArchivo gs = new GestionArchivo(pathID);

            gs.CreateFile();
            string ID = gs.GetDateOne();

            if (ID != null)
            {
                IdVendedor = Convert.ToInt32(ID);
                gs.Delete(IdVendedor.ToString());
            }
            else
                IdVendedor = ListaVendedores.Count + 1;
        }

        public static Vendedor StartList() { Index = 0; if (Count > 0) return ListaVendedores.ElementAt(Index); return null; }
        public static Vendedor EndList() { Index = ListaVendedores.Count - 1; if(Count > 0) return ListaVendedores.ElementAt(Index); return null; }
        public static Vendedor NextList() { Index += 1; if (Index < Count) return ListaVendedores.ElementAt(Index); return EndList(); }
        public static Vendedor BackList() { Index -= 1; if (Index >= 0) return ListaVendedores.ElementAt(Index); return StartList(); }

        public override string ToString()
        {
            return (IdVendedor.ToString() + "\t" + Cedula.ToString() + "\t" + Nombre + "\t" + FechaNacimiento.ToShortDateString() + "\t" +
                Sexo.ToString() + "\t" + Telefono.ToString() + "\t" + Correo + "\t" + Direccion + "\t" +
                EstadoCivil.ToString() + "\t" + FechaIngreso.ToShortDateString() + "\t" +
                Salario.ToString() + "\t" + Profesion + "\t" + Calificacion.ToString());
        }
        public void Add()
        {
            if (ListaVendedores==null)
            {
                ListaVendedores = new List<Vendedor>();
            }

            ListaVendedores.Add(this);
            Save();
        }

        public void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return($"{IdVendedor},{Cedula},{Nombre},{FechaNacimiento.ToShortDateString()},{Sexo},{Telefono},{Correo},{Direccion}," +
                $"{EstadoCivil},{FechaIngreso.ToShortDateString()},{Salario},{Profesion},{Calificacion}");
        }

        public void Delete()
        {
            if (Find(this.IdVendedor))
            {
                ListaVendedores.Remove(this);
                GestionArchivo gs = new GestionArchivo(pathID);
                gs.Save(IdVendedor.ToString());
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

        public static void Update(Vendedor v)
        {
            Edit(ListaVendedores.IndexOf(v), v);
        }

        public void Update()
        {
            Edit(ListaVendedores.IndexOf(this), this);
        }


        public static bool Find(int CodVendedor)
        {
            foreach (Vendedor vendedor in ListaVendedores)
            {
                if (vendedor.IdVendedor == CodVendedor) return true;
            }
            return false;
        }

        public static bool Find(long CedVendedor)
        {
            foreach (Vendedor vendedor in ListaVendedores)
            {
                if (vendedor.Cedula == CedVendedor) return true;
            }
            return false;
        }

        public static Vendedor Search(long CedVendedor)
        {
            foreach (Vendedor v in ListaVendedores)
            {           
                if (v.Cedula == CedVendedor)
                {
                    return v;
                }
            }
            return null;
        }
        public static Vendedor SearchID(int IdVendedor)
        {
            foreach (Vendedor v in ListaVendedores)
            {
                if (v.IdVendedor == IdVendedor)
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
                    IdVendedor = Convert.ToInt32(value);                   
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
                case 9:
                    FechaIngreso = Convert.ToDateTime(value);
                    break;
                case 10:
                    Salario = Convert.ToInt32(value);
                    break;
                case 11:
                    Profesion = value.ToString();
                    break;
                case 12:
                    Calificacion = Convert.ToInt32(value);
                    break;
            }
        }

        public static void LoadList()
        {
            ListaVendedores = new List<Vendedor>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');

                    Vendedor v = new Vendedor();
                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaVendedores.Add(v);

                }

                reader.Close();
            }
        }

        
    }
}