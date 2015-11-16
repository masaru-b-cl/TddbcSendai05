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
  }
}