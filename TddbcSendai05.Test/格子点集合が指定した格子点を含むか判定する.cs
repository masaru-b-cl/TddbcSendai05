using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TddbcSendai05.Test
{
  [TestFixture]
  public class 格子点集合が指定した格子点を含むか判定する
  {
    [TestCase]
    public void 空の格子点集合が指定した格子点を含まない()
    {
      var set = new GridPointSet(null, null);
      bool contains = set.Contains(new GridPoint(0, 0));
      contains.IsFalse();
    }

    [TestCase]
    public void 格子点集合の1つ目の格子点と同じ格子点を含む()
    {
      var set = new GridPointSet(new GridPoint(0, 0), null);
      bool contains = set.Contains(new GridPoint(0, 0));
      contains.IsTrue();
    }

    [TestCase]
    public void 格子点集合の2つ目の格子点と同じ格子点を含む()
    {
      var set = new GridPointSet(null, new GridPoint(0, 0));
      bool contains = set.Contains(new GridPoint(0, 0));
      contains.IsTrue();
    }

    [TestCase]
    public void 格子点集合に同じ格子点を含まない()
    {
      var set = new GridPointSet(new GridPoint(0, 1), new GridPoint(1, 0));
      bool contains = set.Contains(new GridPoint(0, 0));
      contains.IsFalse();
    }

  }
}
