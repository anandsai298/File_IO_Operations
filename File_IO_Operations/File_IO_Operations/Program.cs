// See https://aka.ms/new-console-template for more information
using System;
namespace File_IO_Operations;
class program
{
    static void Main(string[] args)
    {
        Operation op= new Operation();
        op.FileExists(@"F:\File_IO_Operations\File_IO_Operations\File_IO_Operations\TextFile1.txt");
        Console.WriteLine("FileReadAllLines");
        op.FileReadAllLines(@"F:\File_IO_Operations\File_IO_Operations\File_IO_Operations\TextFile1.txt");
        Console.WriteLine("FileReadAllText");
        op.FileReadAllText(@"F:\File_IO_Operations\File_IO_Operations\File_IO_Operations\TextFile1.txt");
        Console.WriteLine("FileCopy");
        op.FileCopy(@"F:\File_IO_Operations\File_IO_Operations\File_IO_Operations\TextFile1.txt","bheemnayaka");
        Console.WriteLine("FileDelete");
        op.FileDelete("wviwbviybviwbvi");
        Console.WriteLine("FileStreamReader");
        op.FileStreamReader(@"F:\File_IO_Operations\File_IO_Operations\File_IO_Operations\TextFile1.txt");
        Console.WriteLine("FileStreamWriter");
        op.FileStreamWriter(@"F:\File_IO_Operations\File_IO_Operations\File_IO_Operations\TextFile1.txt");
    }
}

