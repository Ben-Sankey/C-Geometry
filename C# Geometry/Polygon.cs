//

using System.Diagnostics.CodeAnalysis;
using Coordinate;

class Polygon
{
    //Measurements
    private double diamater;
    private double radius;
    private double apothem;

    //Sides 
    private int sides;
    private double sideLength;

    //Interiors
    private int diagonals;
    private double perimiter;

    //Area
    private double area;
    private double triangleAreas;

    //Angles 
    private int interalAngle;
    private int externalAngle;
    private int interiorAngleSum;

    //coordinates
    private List<Coordinate> coordinates;

    //Enum checks 
    enum MeasureType
    {
        Diaeter, 
        Radius,
        Apothem, 
    }

    //Get functions
    public double Diamater { get { return diamater; } }
    public double Radius { get { return radius; } }
    public double Apothem { get { return apothem; } }
    public int Sides { get { return sides; } }
    public double SideLength { get { return sideLength; } }
    public int Diagonals { get { return diagonals; } }
    public double Perimiter { get { return perimiter; } }
    public double Area { get { return area; } }
    public double TriangleAreas { get { return triangleAreas; } }
    public int InteralAngle { get { return interalAngle; } }
    public int ExternalAngle { get { return externalAngle; } }
    public int InteriorAngleSumDiamater { get { return interiorAngleSum; } }
    public List<Coordinate> Coordinates { get { return coordinates; } }


    public Polygon (int InputSides, float InputRadius)
    {

    }









}
