using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UtilidadesGestionArchivo;

namespace Venta
{
    public class Venta
    {
        public static List<Venta> ListaVentas;
        public static string path = "Files/Venta.txt";
        public static string pathID = "Files/IDs/IdInventario.txt";
        public static string[] Titles = { "ID", "ID Cliente", "ID Vendedor", "ID Item", "Forma de pago" };

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public int IdItem { get; set; }
        public FormaPago FormaPago { get; set; }

        public static int Index { get; set; }

        public static int Count { get; set; }

        public Venta()
        {
            Count = ListaVentas.Count;

            GestionArchivo gs = new GestionArchivo(pathID);

            gs.CreateFile();
            string ID = gs.GetDateOne();

            if (ID != null)
            {
                IdVenta = Convert.ToInt32(ID);
                gs.Delete(IdVenta.ToString());
            }
            else
                IdVenta = ListaVentas.Count + 1;
        }

        public static Venta StartList() { Index = 0; if (Count > 0) return ListaVentas.ElementAt(Index); return null; }
        public static Venta EndList() { Index = ListaVentas.Count - 1; if (Count > 0) return ListaVentas.ElementAt(Index); return null; }
        public static Venta NextList() { Index += 1; if (Index < Count) return ListaVentas.ElementAt(Index); return EndList(); }
        public static Venta BackList() { Index -= 1; if (Index >= 0) return ListaVentas.ElementAt(Index); return StartList(); }


        public void Add()
        {
            if (ListaVentas == null)
            {
                ListaVentas = new List<Venta>();
            }

            ListaVentas.Add(this);
            Save();
        }

        private void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return $"{IdVenta},{IdCliente},{IdVendedor},{IdItem},{FormaPago}";
        }

        public void Delete()
        {
            if (Find(this.IdVenta))
            {
                ListaVentas.Remove(this);
                GestionArchivo gs = new GestionArchivo(pathID);
                gs.Save(IdVenta.ToString());
            }
        }
        public static void Delete(object data)
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Delete(data);
        }

        public static void Update(Venta V)
        {
            Edit(ListaVentas.IndexOf(V), V);
        }

        public static void Edit(int linea, object data)
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Edit(linea, data);
        }

        public override string ToString()
        {
            return (IdVenta.ToString() + "\t" + IdCliente.ToString() + "\t" + IdVendedor.ToString() +
                "\t" + IdItem.ToString() + "\t" + FormaPago.ToString());
        }

        public static bool Find(int IdVenta)
        {
            foreach (Venta Venta in ListaVentas)
            {
                if (Venta.IdVenta == IdVenta) return true;
            }
            return false;
        }

        public static Venta SearchID(int IdVenta)
        {
            LoadList();
            foreach (Venta v in ListaVentas)
            {
                if (v.IdVenta == IdVenta)
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
                    IdVenta = Convert.ToInt32(value);
                    break;
                case 1:
                    IdCliente = Convert.ToInt32(value);
                    break;
                case 2:
                    IdVendedor = Convert.ToInt32(value);
                    break;
                case 3:
                    IdItem = Convert.ToInt32(value);
                    break;
                case 4:
                    FormaPago = (FormaPago)FormaPago.Parse(typeof(FormaPago), value.ToString());
                    break;

            }
        }

        public static void LoadList()
        {
            ListaVentas = new List<Venta>();
            if (File.Exists("Files/Venta.txt"))
            {
                StreamReader reader = new StreamReader("Files/Venta.txt");

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');

                    Venta v = new Venta();
                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaVentas.Add(v);

                }

                reader.Close();
            }
        }
    }
}
