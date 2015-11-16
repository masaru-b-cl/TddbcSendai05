using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TddbcSendai05.Test
{
  [TestFixture]
  public class 格子点を生成する
  {
    [TestCase]
    public void 整数を与えて生成した格子点のX座標を取得する()
    {
      GridPoint gp = new GridPoint(x: 1, y: 2);

      gp.X.Is(1);
    }

    [TestCase]
    public void 整数を与えて生成した格子点のY座標を取得する()
    {
      GridPoint gp = new GridPoint(x: 1, y: 2);

      gp.Y.Is(2);
    }

    [TestCase]
    public void 整数を与えて生成した格子点の文字列表記を取得する()
    {
      GridPoint gp = new GridPoint(x: 1, y: 2);

      gp.ToString().Is("(1,2)");
    }
  }
}
