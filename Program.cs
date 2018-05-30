using System;
using System.Text;
using System.IO;
using TagLib;
using TagLib.Id3v2;
using NAudio.Wave;
using NLayer.NAudioSupport;
namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TagLib.File file = TagLib.File.Create("./flute.mp3");
            Console.WriteLine("File:               " + file);
            Console.WriteLine("File Tag:           " + file.Tag);
            Console.WriteLine("File Tag Performers:" + file.Tag.Performers[0]);
            Console.WriteLine("File Tag Title:     " + file.Tag.Title);
            Console.WriteLine("File Tag Track:     " + file.Tag.Track);
            Console.WriteLine("File Tag Album:     " + file.Tag.Album);
            Console.WriteLine("File Tag Year:      " + file.Tag.Year);
            Console.WriteLine("File Tag Comment:   " + file.Tag.Comment);
            file.Tag.Comment = "41207265616c6c79206c6f6e672073656e74656e636520746861742077696c6c20626520636f6e76657274656420696e746f2068617368a";
            Console.WriteLine("File Tag Genres:    " + file.Tag.Genres);
            Console.WriteLine("File Tag Track:     " + file.Tag.Track);
            Console.WriteLine("File Tag Comment:   " + file.Tag.Comment);
            file.Save();
            // getStream("pew.mp3");
        }
    }
}
