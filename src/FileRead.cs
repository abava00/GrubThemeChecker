using System;
using System.IO; //well... you will need [STAThread] ?

namespace Grub{

  public class Reader{

    //Show Text
    public void Read(string filename){
      foreach (string line in File.ReadLines(filename)){
        Splitter plt = new Splitter();
        string[] temp = new string[2];

        if(Splitter.parter_exist_check(line, ':')){
          temp = plt.colon(line);
          Text.token.Add(temp[0], temp[1]);
        }
        if(Splitter.parter_exist_check(line, '{')){
          temp = plt.plus(line);
          Text.token.Add(temp[0], temp[1]);
        }

      }
      foreach (var i in Text.token){
        Console.WriteLine("key-> " + i.Key + "\nvalue-> " + i.Value);
      }
    }
  }
}
