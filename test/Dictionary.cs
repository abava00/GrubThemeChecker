using System;
using System.Collections.Generic;

public class dict{
  public static void Main(){
    var dic = new Dictionary<string,int>(){
      {"hello", 0655},
      {"world", 2755}
    };

    dic.Add("for", 05);//辞書の追加

    // Console.WriteLine(dic);
    Console.WriteLine(dic["hello"]);
    Console.WriteLine(dic["for"]);

    foreach (var i in dic){
      Console.WriteLine(i.Key + ":" + i.Value);
    }

    dic.Remove("for");//辞書の削除
    foreach (var i in dic){
      Console.WriteLine(i.Key + ":" + i.Value);
    }


  }
}