using System.Drawing;

class Coordinates
{
    public struct Coordinate
    {
        public int x;
        public int y;
    }

    //Generate Functions
    public static Coordinate[] CalculateCoordinates(double InputRadius, int InputSides)
    {
        // Calculate the coordinates of the vertices of a regular polygon
        Coordinate[] Coords = new Coordinate[InputSides];
        double AngleStep = 360.0 / InputSides;
        double Angle = 0;
        double Radian = 0;
        int xCoord = 0;
        int yCoord = 0;

        for (int i = 0; i < InputSides; i++)
        {
            Angle = i * AngleStep;
            Radian = Angle * (Math.PI / 180.0);
            xCoord = (int)Math.Round(InputRadius * Math.Cos(Radian), 0);
            yCoord = (int)Math.Round(InputRadius * Math.Sin(Radian), 0);
            Coords[i].x = xCoord;
            Coords[i].y = yCoord;
        }
        return Coords;
    }

    public static Point[] CalculatePointCoordinates(double InputRadius, int InputSides)
    {
        Point[] Coords = new Point[InputSides];
        double AngleStep = 0.0;
        double Angle = 0.0;
        double Radian = 0.0;
        int xCoord = 0;
        int yCoord = 0;


        for (int i = 0; i < InputSides; i++)
        {
            Angle = i * AngleStep;
            Radian = Angle * (Math.PI / 180.0);
            xCoord = (int)Math.Round(InputRadius * Math.Cos(Radian), 0);
            yCoord = (int)Math.Round(InputRadius * Math.Sin(Radian), 0);
            Coords[i].X = xCoord;
            Coords[i].Y = yCoord;
            
        }
        return Coords;
    }
    //conversion functions 
    public static Point CoordinateToPoint(Coordinate InCoord)
    {
        Point OutPoint = new Point();
        OutPoint.X = InCoord.x;
        OutPoint.Y = InCoord.y;
        return OutPoint;
    }
    public static Coordinate PointToCoordinate(Point InPoint)
    {
        Coordinate OutCoord = new Coordinate();
        OutCoord.x = InPoint.X;
        OutCoord.y = InPoint.Y;
        return OutCoord;
    }
    public static Point[] CoordinatesToPoints(Coordinate[] InCoords)
    {
        Point[] OutPoints = new Point[InCoords.Length];
        for (int i = 0; i < InCoords.Length; i++)
        {
            OutPoints[i] = CoordinateToPoint(InCoords[i]);
        }
        return OutPoints;
    }
    public static Coordinate[] PointsToCoordinates(Point[] InPoints)
    {
        Coordinate[] OutCoords = new Coordinate[InPoints.Length];
        for (int i = 0; i < InPoints.Length; i++)
        {
            OutCoords[i] = PointToCoordinate(InPoints[i]);
        }
        return OutCoords;
    }

    //print functions

    public static void PrintCoordinates(Coordinate[] InCoords)
    {
        for (int i = 0; i < InCoords.Length; i++)
        {
            Console.WriteLine("[" + InCoords[i].x + "," + InCoords[i].y + "]");
        }
    }

    public static void CreatePoint(Point[] InPoints)
    {
        for (int i = 0; i < InPoints.Length; i++)
        {
            Console.WriteLine("[" + InPoints[i].X + "," + InPoints[i].Y + "]");
        }
    }

    public static string CoordinatesToString(Coordinate[] InCoords)
    {
        string OutString = "";
        for (int i = 0; i < InCoords.Length; i++)
        {
            OutString += "[" + InCoords[i].x + "," + InCoords[i].y + "], ";
        }
        return OutString;
    }

    public static string PointsToString(Point[] InPoints)
    {
        string OutString = "";
        for (int i = 0; i < InPoints.Length; i++)
        {
            OutString += "[" + InPoints[i].X + "," + InPoints[i].Y + "], ";
        }
        return OutString;
    }
}
