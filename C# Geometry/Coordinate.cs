using System;

public struct Coordinate
{
    private readonly double x;
    private readonly double y;

    public double X { get { return x; } }
    public double Y { get { return y; } }

    public Coordinate(double latitude, double longitude)
    {
        this.x = latitude;
        this.y = longitude;
    }


}
