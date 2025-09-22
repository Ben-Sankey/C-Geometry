//

using System.Diagnostics.CodeAnalysis;
using static Coordinates;
using static Geometry;

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
    private int exteriorAngleSum;

    //coordinates
    private Coordinate[] coordinates;

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
    public int ExteriorAngleSumDiamater { get { return exteriorAngleSum; } }
    public Coordinate[] PolygonCoordinates { get { return coordinates; } }


    public Polygon (int InputSides, double InputRadius)
    {


    //Measurements
    this.diamater = Geometry.Diamater(InputRadius);
    this.radius = InputRadius;
    this.apothem = Geometry.Apothem(InputRadius, InputSides);

    //Sides 
    this.sides = InputSides; 
    this.sideLength = Geometry.SidesLengthRadius(InputRadius, InputSides);

    //Interiors
    this.diagonals = Geometry.Diagonals(InputSides);
    this.perimiter = Geometry.Perimiter(InputRadius, InputSides, 'R');

    //Area
    this.area = Geometry.Area(InputRadius, InputSides, 'R'); ;
    this.triangleAreas = Geometry.InternalTriangleArea(this.Apothem, InputSides);

    //Angles 
    this.interalAngle = Geometry.InteriorAngles(InputSides);
    this.externalAngle = Geometry.ExteriorAngles(InputSides);
    this.interiorAngleSum = this.InteralAngle * InputSides;

    //coordinates
    this.coordinates = Coordinates.CalculateCoordinates(InputRadius, InputSides);

    }

    









}
