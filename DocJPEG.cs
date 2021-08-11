using System;
using System.IO;

namespace Document
{
    public class DocJPEG : Doc

    {
        public override void Create(string path, string name)
        {
            try
            {
                FileStream fs = new FileStream( path + name + ".jpeg", FileMode.Create);
            }
            catch (Exception ex)
            {   Console.WriteLine("Error: " + ex);    }
        }

        public override string Open(string path, string name)
        {
            string line = null; 
            try
            {
                using (BinaryReader br = new BinaryReader(File.Open(path + name + ".jpeg", FileMode.Open)))
                {
                    line = br.Read().ToString();
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
                using (BinaryWriter bw = new BinaryWriter(File.Open(path + ".jpeg", FileMode.Open)))
                {
                    bw.Write(line);
                }
            }
            catch (Exception ex)
            {   Console.WriteLine("Error: " + ex);    }
        }

        public override void SaveAs(string path, string line)
        {
            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(path + ".jpeg", FileMode.Open)))
                {
                    bw.Write(line);
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