using System;

namespace Grub{

  public class Splitter{

    public static bool ParterExitsCheck(string line, char parter){
      /*:や+,{}などがlineに存在するかどうか確認する*/
      foreach(var i in line){
        if(i == parter){
          return true;
        }
      }
      return false;
    }

    public string[] Colon(string line){
      /*
       * 入力が
       * title-text: "TITLE"
       * のようなときに
       * [title-text, "TITLE"]
       * */
      char part = ':';
      string[] temp = line.Split(part);
      //Console.WriteLine(temp[0]);
      //Console.WriteLine(temp[1]);
      return temp;
    }

    public string[] Equal(string line){
      /*
       * 入力が
       * letf = 50%-300
       * 出力
       * [left, 50%-300]
       * */

      string[] temp = line.Split('+');
      //Console.WriteLine(temp[0]);
      //Console.WriteLine(temp[1]);

      return temp;
    }

    public string[] Plus(string line){
      /*
       * 入力が
       * (+) boot_menu {
       *       left = 50%-300
       *       top = 50%-100
       *       ...
       *       selected_item_color = "#0000FF"
       * }
       * 出力
       * [boot_menu, left =...00FF]
       */

      string[] temp = line.Split('+');
      temp = temp[1].Split('{');

      return temp;
    }

    public void AAA(string line){
      bool in_doublequo = false;
      string word = "";//""の中身の文字列を格納する

      foreach(char c in line){
        if(in_doublequo){
          //ダブルクオーテーションの内側
          if(c == '"'){
            in_doublequo = false;
            Console.WriteLine("中最後");
            Console.WriteLine(word);
            word = "";

          }else{
            Console.WriteLine("中");
            word += c;
          }
        }else{
          //ダブルクオーテーションの外側
          if(c == '"'){
            in_doublequo = true;
            Console.WriteLine("中最初");
          }else{
            Console.WriteLine("外");
          }
        }
      }
    }
  }
}
