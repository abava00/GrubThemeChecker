using System.Collections.Generic;

/*
  グローバル変数的な感じでおいていくもの
  これで許されるのだろうか
*/

namespace Grub{
    public static class Text{
      /* Themeから抜いたデータを入れるところ
          title-text: "Title Text"
          なら
          {key, value} = {"title-text", "Title Text"}
          みたくなるように
      */
      public static Dictionary<string, string> token = new Dictionary<string, string>();
  }

}
