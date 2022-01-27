using System;
using System.IO; //well... you will need [STAThread] ?

namespace Grub{

  public class Reader{

    //{}内のテキストを1まとまりにする
    public static string stack_text;
    public static string read_text;
    public static bool in_bracket = false;
    public static int counter = 0;

    //Show Text
    public void Read(string filename){

      foreach (string line in File.ReadLines(filename)){
        read_text += convText(line);
      }

      Analyze(read_text);


      foreach (var i in Text.token){
        Console.WriteLine("key-> " + i.Key + "\nvalue-> " + i.Value);
      }
    }

    public string convText(string lines){
      lines = lines.Replace("\n", "");
      lines = lines.Replace(" ", "");

      return lines;
    }

    public static void Analyze(string line){
      Splitter plt = new Splitter();
      string[] temp = new string[2];

      plt.AAA(line);

    }
  }
}
