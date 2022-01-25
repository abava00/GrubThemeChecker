using System;
using System.IO; //well... you will need [STAThread] ?
using System.Windows.Forms;

// var path = string.Empty;
// てやつがあったよ


namespace Grub{

  public class mainWindow : Form{
    public static void Main(){
      Application.Run(new mainWindow());
    }

    mainWindow(){

      //init
      this.Height = 300;
      this.Width = 300;
      this.Text = "MainWindow";

      //set parts
      Button rfb = new Button();
      rfb.Text = "Open File";
      rfb.Top = 5;
      rfb.Left = 5;
      rfb.Height = 50;
      rfb.Width = 50;
      rfb.Parent = this;

      // Grub.Text.token.Add("hello", "World");

      //events
      // rfb.Click += OpenFileSelectDialog;
      rfb.Click += Dummy_OpenFileSelectDialog;
    }

    public void OpenFileSelectDialog(Object sender, EventArgs e){
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.ShowHelp = true; //これがあるとなんか応答待ちにならなくてすむようになる
      ofd.Filter = "テキストファイル(*.txt)|*.txt";

      if (ofd.ShowDialog() == DialogResult.OK){
        Reader read_text = new Reader();
        // read_text.Read(Path.GetFullPath(ofd.FileName));
        read_text.Read(Path.GetFullPath("sample.txt"));
      }
    }

    public void Dummy_OpenFileSelectDialog(Object sender, EventArgs e){
      Reader read_text = new Reader();
      read_text.Read(Path.GetFullPath("sample.txt"));
      this.Close();
    }
  }
}