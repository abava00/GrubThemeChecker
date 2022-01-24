using System;
using System.Collections.Generic;

public class part{
  public static void Main(){
    Console.WriteLine("list の勉強");
    var list = new List<string>();
    string[] text = {"for", "b"};
    list.Add("hello");//追加
    list.Add("world");
    list.AddRange(text);//listにlistを追加する

    Console.WriteLine(list);
    Console.WriteLine(list[0]);
    // Console.WriteLine(list[10]); //今の状態だとエラーになる
    Console.WriteLine(string.Join(",", list));
    list.Sort();
    list.Insert(2, "GOD");//途中に追加する
    Console.WriteLine(string.Join(",", list));
    list.Remove("hello");
    list.Remove("world");
    Console.WriteLine(string.Join(",", list));
    Console.WriteLine(list.IndexOf("GOD"));
  }
}