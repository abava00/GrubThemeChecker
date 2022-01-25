using System;

namespace Grub{


  public class Splitter{
    public string[] colon(string line){

      string[] temp = line.Split(':');
      Console.WriteLine(temp[0]);
      Console.WriteLine(temp[1]);

      return temp;
    }
  }
}