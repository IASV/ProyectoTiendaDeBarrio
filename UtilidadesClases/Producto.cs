using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UtilidadesGestionArchivo;

namespace UtilidadesClases
{
    public class Producto
    {
        public static List<Producto> ListaProductos;
        public static string path = "Files/Producto.txt";
        public static string pathID = "Files/IDs/IdProducto.txt";
        DateTime fechaSalida = DateTime.Parse("01/01/0001");

        public static string[] Titles = { "ID", "Nombre", "Información", "Fecha de ingreso", "Fecha de salida" };

        public static int Index { get; set; }

        public static int Count { get; set; }

        public Producto()
        {
            Count = ListaProductos.Count;

            GestionArchivo gs = new GestionArchivo(pathID);

            gs.CreateFile();
            string ID = gs.GetDateOne();

            if (ID != null)
            {
                IdProducto = Convert.ToInt32(ID);
                gs.Delete(IdProducto.ToString());
            }
            else
                IdProducto = ListaProductos.Count + 1;
        }

        public static Producto StartList() { Index = 0; if (Count > 0) return ListaProductos.ElementAt(Index); return null; }
        public static Producto EndList() { Index = ListaProductos.Count - 1; if (Count > 0) return ListaProductos.ElementAt(Index); return null; }
        public static Producto NextList() { Index += 1; if (Index < Count) return ListaProductos.ElementAt(Index); return EndList(); }
        public static Producto BackList() { Index -= 1; if (Index >= 0) return ListaProductos.ElementAt(Index); return StartList(); }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Info { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }

        public void Add()
        {
            if (ListaProductos == null)
            {
                ListaProductos = new List<Producto>();
            }

            ListaProductos.Add(this);

            Save();
        }

        private void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return $"{IdProducto},{Nombre},{Info}," +
                $"{FechaIngreso.ToShortDateString()},{FechaSalida.ToShortDateString()}";
        }

        public void Delete()
        {
            if (Find(this.IdProducto))
            {
                ListaProductos.Remove(this);
                GestionArchivo gs = new GestionArchivo(pathID);
                gs.Save(IdProducto.ToString());
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

        public static void Update(Producto c)
        {
            Edit(ListaProductos.IndexOf(c), c);
        }

        public override string ToString()
        {
            return (IdProducto.ToString() + "\t" + Nombre + "\t" + Info + "\t" + FechaIngreso.ToShortDateString() + "\t" + FechaSalida.ToShortDateString());
        }

        public static bool Find(int IdProducto)
        {
            foreach (Producto Producto in ListaProductos)
            {
                if (Producto.IdProducto == IdProducto) return true;
            }
            return false;
        }

        public static bool FindForName(string Nombre)
        {
            foreach (Producto Producto in ListaProductos)
            {
                if (Producto.Nombre.ToLower() == Nombre.ToLower()) return true;
            }
            return false;
        }

        public static Producto Search(int IdProducto)
        {
            foreach (Producto v in ListaProductos)
            {
                if (v.IdProducto == IdProducto)
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
                    IdProducto = Convert.ToInt32(value);
                    break;
                case 1:
                    Nombre = value.ToString();
                    break;
                case 2:
                    Info = value.ToString();
                    break;
                case 3:
                    FechaIngreso = DateTime.Parse(value);
                    break;
                case 4:
                    FechaSalida = DateTime.Parse(value);
                    break;
            }
        }

        public static void LoadList()
        {
            ListaProductos = new List<Producto>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');

                    Producto v = new Producto();
                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaProductos.Add(v);

                }

                reader.Close();
            }
        }

    }
}
