using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UtilidadesGestionArchivo
{
    public class GestionArchivo
    {
        public string Path { get; set; }
        public string PathTemp { get; set; }

        public GestionArchivo(string path)
        {
            Path = path;
        }

        public GestionArchivo()
        {
     
        }

        public void Save(string Line)
        {
            StreamWriter writer = new StreamWriter(Path, true);

            writer.WriteLine(Line);

            writer.Close();
        }

        public void Delete(object data)
        {
            using (StreamWriter fileWrite = new StreamWriter("Files/temp.txt", true))
            {
                using (StreamReader fielRead = new StreamReader(Path))
                {
                    string line;

                    while ((line = fielRead.ReadLine()) != null)
                    {
                        string[] datos = line.Split(new char[] { ',' });
                        string[] dateValues = (data.ToString()).Split('\t');
                        if (datos[0].ToString() != dateValues[0].ToString())
                        {
                            fileWrite.WriteLine(line);
                        }

                    }
                }
            }

            //aqui se renombrea el archivo temporal
            File.Delete(Path);
            File.Move("Files/temp.txt", Path);
        }

        //public void Edit(int indexLine, int i, object data)
        //{
        //    string[] All = File.ReadAllLines(Path);
        //    string[] Lines = (All[indexLine]).Split(',');
        //    string[] date = (data.ToString()).Split('\t');

        //    /*int calificacion = Convert.ToInt32(date[12]);
        //    date[12] = calificacion.ToString();*/

        //    Lines[i] = date[i];
        //    string dataText = "";
        //    for (int j = 0; j < Lines.Length; j++)
        //    {
        //        if (Lines[j] != "\n")
        //            dataText += Lines[j];
        //        if (j < Lines.Length - 1)
        //            dataText += ",";
        //    }

        //    All[indexLine] = dataText;

        //    File.WriteAllLines(Path, All);
        //}

        public void Edit(int indexLine, object data)
        {
            string[] All = File.ReadAllLines(Path);
            string[] date = (data.ToString()).Split('\t');

            string dataText = "";
            for (int j = 0; j < date.Length; j++)
            {
                    dataText += date[j];
                if (j < date.Length - 1)
                    dataText += ",";
            }

            All[indexLine] = dataText;

            File.WriteAllLines(Path, All);
        }

        public string[][] GetDataString()
        {

            string[] All = File.ReadAllLines(Path);
            string[][] dataOutput = new string[All.Length][];

            if (new FileInfo(Path).Length > 0)//Comprueba si el archivo tiene contenido
            {
                for (int i = 0; i < All.Length; i++)
                {
                    dataOutput[i] = All[i].ToString().Split(',');
                }
                return dataOutput;
            }
            else
                return null;
        }

        public string GetDateOne()
        {
            if (new FileInfo(Path).Length > 0)
            {
                string[] All = File.ReadAllLines(Path);
                return All[0];
            }
            else
                return null;
        }

        public void CreateFile()
        {
            StreamWriter fileWrite = new StreamWriter(Path, true);
            fileWrite.Close();
        }

        public string SearchDate(object date, int position)
        {

            string line = "";
            if (!File.Exists(PathTemp))
                CreateFile();
            else
            {
                if (new FileInfo(Path).Length > 0)
                {
                    StreamReader fileRead = new StreamReader(Path);

                    Path = PathTemp;

                    while ((line = fileRead.ReadLine()) != null)
                    {
                        string[] datos = line.Split(new char[] { ',' });

                        if (Convert.ToInt32(datos[position].ToString()) == Convert.ToInt32(date.ToString()))
                        {
                            Save(datos[1] + "," + datos[2]);
                            fileRead.Close();
                            return line;
                        }
                    }
                }
            }
            return null;
        }

        public bool SearchData(string date, int position)
        {
            bool state = false;
            string line = "";

            if (new FileInfo(Path).Length > 0)
            {
                StreamReader fileRead = new StreamReader(Path);

                Path = PathTemp;

                DeleteFile();
                CreateFile();

                while ((line = fileRead.ReadLine()) != null)
                {
                    string[] datos = line.Split(new char[] { ',' });

                    if (datos[position].ToUpper().ToString() == date.ToUpper().ToString())
                    {
                        Save(line);
                        state = true;
                    }
                }
                fileRead.Close();
                return state;
            }
            return state;
        }

        public void DeleteFile()
        {
            if(File.Exists(Path))
                File.Delete(Path);
        }

        public void Duplicate(string old, string newFile)
        {
            if (File.Exists(newFile))
            {
                File.Delete(newFile);
                File.Copy(old, newFile);
            }
        }

    }
}
