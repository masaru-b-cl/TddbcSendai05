using System;
using System.Linq;

namespace TddbcSendai05
{
  public class GridPointSet
  {
    private GridPoint gridPoint1;
    private GridPoint gridPoint2;

    public GridPointSet(GridPoint gridPoint1, GridPoint gridPoint2)
    {
      this.gridPoint1 = gridPoint1;
      this.gridPoint2 = gridPoint2;
    }

    public bool Contains(GridPoint target)
    {
      var gps = new[] { gridPoint1, gridPoint2 };
      if (gps.Any(gp => gp != null && gp.HasSameCoordinatesWith(target)))
      {
        return true;
      }
      return false;
    }

    public bool IsConnected
    {
      get
      {
        var gps = new[] { gridPoint1, gridPoint2 };
        if (gps.Any(gp => gp == null)) return false;

        if (gridPoint1.IsNeighborOf(gridPoint2)) return true;

        return false;
      }
    }
  }
}