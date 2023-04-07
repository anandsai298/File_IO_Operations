using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Operations
{
    public class Operation
    {
        public void FileExists(string path)
        {
            if (File.Exists(path))
                Console.WriteLine("file exists");
            else
                Console.WriteLine("file not exists");
        }
        public void FileReadAllLines(string path)
        {
            if (File.Exists(path))
            {
                string[] lines=File.ReadAllLines(path);
                foreach(var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
                Console.WriteLine("file not exists");
        }
        public void FileReadAllText(string path)
        {
            if (File.Exists(path))
            {
                string lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
            else
                Console.WriteLine("file not exists");
        }
        public void FileCopy(string path,string NewFile)
        {
            if (File.Exists(path))
            {
                File.Copy(path, NewFile);
            }
            else
                Console.WriteLine("file not exists");
        }
        public void FileDelete(string NewFile)
        {
            if (File.Exists(NewFile))
            {
                File.Delete(NewFile);
            }
            else
                Console.WriteLine("file not exists");
        }
        public void FileStreamReader(string path)
        {
            if(File.Exists(path))
            {
                using(StreamReader sr =File.OpenText(path))
                {
                    while(sr.ReadLine()!=null)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            else
                Console.WriteLine("file not exists");
        }
        public void FileStreamWriter(string path)
        {
            if (File.Exists(path))
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    string word = "telusa manasa";
                    sr.WriteLine(word);
                    sr.Close();
                    Console.WriteLine(File.ReadAllText(path));
                }
            }
            else
                Console.WriteLine("file not exists");
        }
    }
}
