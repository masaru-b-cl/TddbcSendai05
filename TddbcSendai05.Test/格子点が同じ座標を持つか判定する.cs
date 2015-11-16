using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TddbcSendai05.Test
{
  [TestFixture]
  public class 格子点が同じ座標を持つか判定する
  {
    [TestCase]
    public void 同じ格子点は同じ座標を持つ()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(1, 2);

      gp1.HasSameCoordinatesWith(gp2).Is(true);
    }

    [TestCase]
    public void X座標が違う格子点は同じ座標を持たない()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(2, 2);

      gp1.HasSameCoordinatesWith(gp2).Is(false);
    }

    [TestCase]
    public void Y座標が違う格子点は同じ座標を持たない()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(1, 3);

      gp1.HasSameCoordinatesWith(gp2).Is(false);
    }
  }
}
