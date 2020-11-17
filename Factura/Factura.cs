using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using UtilidadesGestionArchivo;

namespace Factura
{
    public class Factura
    {
        public static List<Factura> ListaFactura;
        public static string path = "Files/Factura.txt";
        public static string pathID = "Files/IDs/IdFactura.txt";

        public static string[] Titles = { "Id Factura", "Id Venta", "Precio Final" };

        public Factura()//Here
        {
            Count = ListaFactura.Count;

            GestionArchivo gs = new GestionArchivo(pathID);
            
            gs.CreateFile();
            string ID = gs.GetDateOne();

            if (ID != null)
            {
                IdFactura = Convert.ToInt32(ID);
                gs.Delete(IdFactura.ToString());
            }
            else
                IdFactura = ListaFactura.Count + 1;
        }

        public static Factura StartList() { Index = 0; if (Count > 0) return ListaFactura.ElementAt(Index); return null; }
        public static Factura EndList() { Index = ListaFactura.Count - 1; if (Count > 0) return ListaFactura.ElementAt(Index); return null; }
        public static Factura NextList() { Index += 1; if (Index < Count) return ListaFactura.ElementAt(Index); return EndList(); }
        public static Factura BackList() { Index -= 1; if (Index >= 0) return ListaFactura.ElementAt(Index); return StartList(); }

        public int IdVenta { get; set; }
        public double precioFinal { get; set; }
        public int IdFactura { get; set; }
        public static int Index { get; set; }
        public static int Count { get; set; }

        public override string ToString()
        {
            return (IdFactura.ToString() + "\t" + IdVenta.ToString() + "\t" + precioFinal.ToString());
        }
        public void Add()
        {
            if (ListaFactura == null)
            {
                ListaFactura = new List<Factura>();
            }

            ListaFactura.Add(this);

            Save();
        }


        private void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return $"{IdFactura},{IdVenta},{precioFinal}";
        }

        public void Delete()
        {
            if (Find(this.IdFactura))
            {
                ListaFactura.Remove(this);
                GestionArchivo gs = new GestionArchivo(pathID);
                gs.Save(IdFactura.ToString());
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
            Edit(ListaFactura.IndexOf(this), this);
        }

        public static void Update(Factura c)
        {
            Edit(ListaFactura.IndexOf(c), c);
        }

        public static bool Find(int IdFactura)
        {
            foreach (Factura Factura in ListaFactura)
            {
                if (Factura.IdFactura == IdFactura) return true;
            }
            return false;
        }

        public static Factura Search(int IdFactura)
        {
            foreach (Factura v in ListaFactura)
            {
                if (v.IdFactura == IdFactura)
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
                    IdFactura = Convert.ToInt32(value);
                    break;
                case 1:
                    IdVenta = Convert.ToInt32(value);
                    break;
                case 2:
                    precioFinal = Convert.ToInt64(value);
                    break;

            }
        }

        public static void LoadList()
        {
            ListaFactura = new List<Factura>();
            if (File.Exists("Files/Factura.txt"))
            {
                StreamReader reader = new StreamReader("Files/Factura.txt");

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');

                    Factura v = new Factura();
                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaFactura.Add(v);

                }

                reader.Close();
            }
        }

        

    }
}
