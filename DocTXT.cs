using System;
using System.IO;

namespace Document
{
    public class DocTXT : Doc
    {
        public override void Create(string path, string name)
        {
            try
            {
                FileStream fs = new FileStream( path + name + ".txt", FileMode.Create);
            }
            catch (Exception ex)
            {   Console.WriteLine("Error: " + ex);    }
        }

        public override string Open(string path, string name)
        {
            string line = null; 
            try
            {
                using (StreamReader sr = new StreamReader(path + name + ".txt"))
                {
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {   Console.WriteLine("Error: " + ex);    }
            return line;
        }

        public override void Save(string path, string line)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {   Console.WriteLine("Error: " + ex);    }
        }

        public override void SaveAs(string path, string line)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {   Console.WriteLine("Error: " + ex);    }
        }

        public override void Print(string path, string name)
        {
           var line = Open(path, name);
           Console.WriteLine(line);
            
        }

        public override void Close()
        {
            Console.WriteLine("What about save?");
        }
    }
}