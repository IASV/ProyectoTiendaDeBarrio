using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UtilidadesGestionArchivo;

namespace Inventario
{
    public class Inventario
    {
        public static List<Inventario> ListaInventario;
        public static string path = "Files/Inventario.txt";
        public static string pathID = "Files/IDs/IdInventario.txt";//Cambio
        DateTime fechaSalida = DateTime.Parse("01/01/0001");

        public static string[] Titles = { "ID", "ID Producto", "Cantidad", "Precio", "Venta", "Facha Ingreso", "Fecha Salida"};

        public static int Index { get; set; }

        public static int Count { get; set; }
        
        public Inventario()//Cambio
        {
            Count = ListaInventario.Count;

            GestionArchivo gs = new GestionArchivo(pathID);
            
            gs.CreateFile();
            string ID = gs.GetDateOne();

            if (ID != null)
            {
                IdInventario = Convert.ToInt32(ID);
                gs.Delete(IdInventario.ToString());
            }
            else
                IdInventario = ListaInventario.Count + 1;
        }

        public static Inventario StartList() { Index = 0; if (Count > 0) return ListaInventario.ElementAt(Index); return null; }
        public static Inventario EndList() { Index = ListaInventario.Count - 1; if (Count > 0) return ListaInventario.ElementAt(Index); return null; }
        public static Inventario NextList() { Index += 1; if (Index < Count) return ListaInventario.ElementAt(Index); return EndList(); }
        public static Inventario BackList() { Index -= 1; if (Index >= 0) return ListaInventario.ElementAt(Index); return StartList(); }

        public int IdInventario { get; set; }
        public int IdProducto { get; set; }       
        public int Cantidad { get; set; }
        public long PrecioBase { get; set; }
        public long PrecioVenta { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }

        public void Add()
        {
            if (ListaInventario == null)
            {
                ListaInventario = new List<Inventario>();
            }

            ListaInventario.Add(this);

            Save();
        }

        private void Save()
        {
            GestionArchivo gs = new GestionArchivo(path);
            gs.Save(this.GetLine());
        }

        private string GetLine()
        {
            return $"{IdInventario},{IdProducto},{Cantidad}," +
                $"{PrecioBase},{PrecioVenta},{FechaIngreso.ToShortDateString()},{FechaSalida.ToShortDateString()}";
        }

        public override string ToString()
        {
            return (IdInventario.ToString() + "\t" + IdProducto.ToString() + "\t" + Cantidad.ToString() + "\t" + PrecioBase.ToString() + "\t" +
                PrecioVenta.ToString() + "\t" + FechaIngreso.ToShortDateString() + "\t" + FechaSalida.ToShortDateString());
        }

        public void Delete()//Here
        {
            if (Find(this.IdInventario))
            {
                ListaInventario.Remove(this);
                GestionArchivo gs = new GestionArchivo(pathID);
                gs.Save(IdInventario.ToString());
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
            Edit(ListaInventario.IndexOf(this), this);
        }

        public static void Update(Inventario c)
        {
            Edit(ListaInventario.IndexOf(c), c);
        }

        public static bool Find(int IdInventario)
        {
            foreach (Inventario v in ListaInventario)
            {
                if (v.IdInventario == IdInventario) return true;
            }
            return false;
        }

        public static bool FindForIDProduct(int IdProducto)
        {
            foreach (Inventario v in ListaInventario)
            {
                if (v.IdProducto == IdProducto) return true;
            }
            return false;
        }

        public static Inventario Search(int IdInventario)
        {
            foreach (Inventario v in ListaInventario)
            {
                if (v.IdInventario == IdInventario)
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
                    IdInventario = Convert.ToInt32(value);
                    break;
                case 1:
                    IdProducto = Convert.ToInt32(value);
                    break;
                case 2:
                    Cantidad = Convert.ToInt32(value);
                    break;
                case 3:
                    PrecioBase = Convert.ToInt64(value);
                    break;
                case 4:
                    PrecioVenta = Convert.ToInt64(value);
                    break;
                case 5:
                    FechaIngreso = Convert.ToDateTime(value);
                    break;
                case 6:
                    FechaSalida = Convert.ToDateTime(value);
                    break;


            }
        }

        public static void LoadList()
        {
            ListaInventario = new List<Inventario>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string[] var = reader.ReadLine().Split(',');

                    Inventario v = new Inventario();
                    for (int i = 0; i < var.Length; i++)
                    {
                        v.SetItems(i, var[i]);
                    }

                    ListaInventario.Add(v);

                }

                reader.Close();
            }
        }

    }
}
