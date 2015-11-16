using System;

namespace TddbcSendai05
{
  public class GridPoint
  {
    public int X { get; private set; }
    public int Y { get; private set; }

    public GridPoint(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    public override string ToString()
    {
      return $"({X},{Y})";
    }

    public object HasSameCoordinatesWith(GridPoint other)
    {
      if (this.X != other.X) return false;
      if (this.Y != other.Y) return false;
      return true;
    }

    public object IsNeighborOf(GridPoint other)
    {
      if (IsNeighbor(this.X, other.X)) return true;

      return false;
    }

    private static bool IsNeighbor(int value1, int value2)
    {
      return Math.Abs(value1 - value2) == 1;
    }
  }
}