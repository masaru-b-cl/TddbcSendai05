﻿using System;

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

    public bool HasSameCoordinatesWith(GridPoint other)
    {
      if (this.X != other.X) return false;
      if (this.Y != other.Y) return false;
      return true;
    }

    public bool IsNeighborOf(GridPoint other)
    {
      if (
        (IsNeighbor(this.X, other.X) && this.Y == other.Y)
        ^ (IsNeighbor(this.Y, other.Y) && this.X == other.X)
        ) return true;

      return false;
    }

    private static bool IsNeighbor(int value1, int value2)
    {
      return Math.Abs(value1 - value2) == 1;
    }
  }
}