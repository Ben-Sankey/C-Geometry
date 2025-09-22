using System;


public struct Coordinate
{
    public double x;
    public double y;
}

public class Coordinates
{

    public static Coordinate[] CalculateCoordinates(double InputRadius, int InputSides)
    {
        // Calculate the coordinates of the vertices of a regular polygon
        Coordinate[] coords = new Coordinate[InputSides];
        double angleStep = 360.0 / InputSides;
        for (int i = 0; i < InputSides; i++)
        {
            double angle = i * angleStep;
            double radian = angle * (Math.PI / 180.0);
            double xCoord = InputRadius * Math.Cos(radian);
            double yCoord = InputRadius * Math.Sin(radian);
            coords[i].x = xCoord;
            coords[i].y = yCoord;
        }
        return coords;
    }

}
