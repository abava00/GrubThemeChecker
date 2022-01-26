using System;

namespace Grub{

  public class Splitter{

    public static bool parter_exist_check(string line, char parter){
      /*:や+,{}などがlineに存在するかどうか確認する*/
      foreach(var i in line){
        if(i == parter){
          return true;
        }
      }
      return false;
    }

    public string[] colon(string line){
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

    public string[] equal(string line){
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

    public string[] plus(string line){
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

      string[] temp = line.Split('{');

      Console.WriteLine(temp[0]);
      Console.WriteLine(temp[1]);

      return temp;
    }
  }
}
