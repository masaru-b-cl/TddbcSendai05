using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TddbcSendai05.Test
{
  [TestFixture]
  public class 格子点が隣り合っているか判定する
  {
    [TestCase]
    public void 同じ座標は隣り合っていない()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(1, 2);

      gp1.IsNeighborOf(gp2).Is(false);
    }

    [TestCase]
    public void X座標が1大きい座標は隣り合っている()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(2, 2);

      gp1.IsNeighborOf(gp2).Is(true);
    }

    [TestCase]
    public void X座標が2大きい座標は隣り合っていない()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(3, 2);

      gp1.IsNeighborOf(gp2).Is(false);
    }

    [TestCase]
    public void X座標が1小さい座標は隣り合っている()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(0, 2);

      gp1.IsNeighborOf(gp2).Is(true);
    }

    [TestCase]
    public void Y座標が1大きい座標は隣り合っている()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(1, 3);

      gp1.IsNeighborOf(gp2).Is(true);
    }

    [TestCase]
    public void X座標とY座標が共に1大きい座標は隣り合っていない()
    {
      var gp1 = new GridPoint(1, 2);
      var gp2 = new GridPoint(2, 3);

      gp1.IsNeighborOf(gp2).Is(false);
    }
  }
}
