using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TddbcSendai05.Test
{
  [TestFixture]
  public class 格子点集合が連結しているか判定する
  {
    [TestCase]
    public void 空の格子点集合は連結していない()
    {
      var set = new GridPointSet(null, null);
      bool isConnected = set.IsConnected;
      isConnected.IsFalse();
    }

    [TestCase]
    public void 空の要素を含む格子点集合は連結していない()
    {
      var set = new GridPointSet(new GridPoint(0, 0), null);
      bool isConnected = set.IsConnected;
      isConnected.IsFalse();
    }

    [TestCase]
    public void 要素が隣り合った格子点集合は連結している()
    {
      var set = new GridPointSet(new GridPoint(0, 0), new GridPoint(0, 1));
      bool isConnected = set.IsConnected;
      isConnected.IsTrue();
    }

    [TestCase]
    public void 要素が隣り合っていない格子点集合は連結していない()
    {
      var set = new GridPointSet(new GridPoint(0, 0), new GridPoint(0, 2));
      bool isConnected = set.IsConnected;
      isConnected.IsFalse();
    }

  }
}
