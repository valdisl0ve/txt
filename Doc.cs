using System;

namespace Document
{
    public abstract class Doc
    {
        public abstract void Create(string path, string name);
        public abstract string Open(string path, string name);
        public abstract void Save(string path, string line);
        public abstract void SaveAs(string path, string line);
        public abstract void Print(string path, string line);
        public abstract void Close();
    }
}