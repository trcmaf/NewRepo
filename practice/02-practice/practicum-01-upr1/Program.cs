using System;
using System.IO;

namespace practicum_01_upr1
{

  class Program
  {
    static void ShowDirectory(Directorylnfo dir)
    {
      foreach (Filelnfo file in dir.GetFilesO)
      {
        Console.WriteLine("File: {0}", file.FullName);
      }
      foreach (Directorylnfo subDir in dir.GetDirectoriesO)
      {
        ShowDirectory(subDir);
      }
    }
    static void Main(string[] args)
    {
      Directorylnfo dir = new Directorylnfo(Environment.SystemDirectory); 
      ShowDirectory(dir);
    }
  }
}
