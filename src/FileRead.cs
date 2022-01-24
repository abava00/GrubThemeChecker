using System;
using System.IO; //well... you will need [STAThread] ?

namespace Grub{

  public class Reader{

    //Show Text
    public void Show(string filename){
      foreach (string line in File.ReadLines(filename)){
        Console.WriteLine(line);
      }
    }
  }
}