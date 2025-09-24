//
using static Coordinates;
using static Geometry;

class Polygon
{
    //Measurements
    private double diameter;
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

    //Constructor
    public Polygon(double InputRadius, int InputSides)
    {
        //Measurements
        CalDiamater(InputRadius);
        radius = InputRadius;
        CalApothem(InputRadius, InputSides);

        //Sides 
        sides = InputSides;
        CalSideLength(InputRadius, InputSides);

        //Interiors
        CalDiagonals(InputSides);
        CalPerimiter(InputRadius, InputSides);

        //Area
        CalArea(InputRadius, InputSides);
        CalTriangleAreas(InputRadius, InputSides);

        //Angles 
        CalInteralAngle(InputSides);
        CalExternalAngle(InputSides);
        CalInteriorAngleSum(InputSides);
        CalExteriorAngleSum(InputSides);

        //coordinates
        CalPolygonCoordinates(InputRadius, InputSides);

        if(coordinates == null)
        {
            coordinates = new Coordinate[0];
        }

    }

    //Get functions
    public double Diameter { get { return diameter; } }
    public double Radius { get { return radius; } }
    public double Apothem { get { return apothem; } }
    public int Sides { get { return sides; } }
    public double SideLength { get { return sideLength; } }
    public int Diagonals { get { return diagonals; } }
    public double Perimiter { get { return perimiter; } }
    public double Area { get { return area; } }
    public double TriangleAreas { get { return triangleAreas; } }
    public int InternalAngle { get { return interalAngle; } }
    public int ExternalAngle { get { return externalAngle; } }
    public int InteriorAngleSum { get { return interiorAngleSum; } }
    public int ExteriorAngleSum { get { return exteriorAngleSum; } }
    public Coordinate[] VertexCoordinates { get { return coordinates; } }
    
    //Set functions
    public int SetDiamater(double InputDiamater)
    {
        try
        {
            diameter = InputDiamater;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetRadius(double InputRadius)
    {
        try
        {
            radius = InputRadius;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public double SetApothem(double InputApothem) 
    {
        try
        {
            apothem = InputApothem;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetSides(int InputSides)
    {
        try
        {
            sides = InputSides;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetSideLength(double InputSideLength)
    {
        try
        {
            sideLength = InputSideLength;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetDiagonals(int InputDiagonals) 
    {
        try
        {
            diagonals = InputDiagonals;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetPerimiter(double InputPerimiter) 
    {
        try
        {
            perimiter = InputPerimiter;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetArea(double InputArea) 
    {
        try
        {
            area = InputArea;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetTriangleAreas(double InputTriangleAreas) 
    {
        try
        {
            triangleAreas = InputTriangleAreas;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetInteralAngle(int InputInteralAngle) 
    {
        try
        {
            interalAngle = InputInteralAngle;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetExternalAngle(int InputExternalAngle)
    {
        try
        {
            externalAngle = InputExternalAngle;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetInteriorAngleSum(int InputInteriorAngleSum) 
    {
        try
        {
            interiorAngleSum = InputInteriorAngleSum;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetExteriorAngleSum(int InputExteriorAngleSum) 
    {
        try
        {
            exteriorAngleSum = InputExteriorAngleSum;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int SetPolygonCoordinates(Coordinate[] InputCoordinates) 
    {
        try
        {
            coordinates = InputCoordinates;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }

    //Calculate functions
    public int CalDiamater(double InputRadius)
    {
        try
        {
            //Measurements
            diameter = Geometry.Diamater(InputRadius);
            

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    
    public double CalApothem(double InputRadius, int InputSides)
    {
        try
        {
            apothem = Geometry.Apothem(InputRadius, InputSides);

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalSideLength(double InputRadius, int InputSides)
    {
        try
        {
            sideLength = SidesLengthRadius(InputRadius, InputSides);

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalDiagonals(int InputSides)
    {
        try
        {
            //Interiors
            diagonals = Geometry.Diagonals(InputSides);

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalPerimiter(double InputRadius, int InputSides)
    {
        try
        {
            perimiter = Geometry.Perimiter(InputRadius, InputSides, 'R');

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalArea(double InputRadius, int InputSides)
    {
        try
        {
            //Area
            area = Geometry.Area(InputRadius, InputSides, 'R'); ;
           

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalTriangleAreas(double InputRadius, int InputSides)
    {
        try
        {
            triangleAreas = InternalTriangleArea(CalApothem(InputRadius, InputSides), InputSides);
            
            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalInteralAngle(int InputSides)
    {
        try
        {
            //Angles 
            interalAngle = InteriorAngles(InputSides);
            
            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalExternalAngle(int InputSides)
    {
        try
        {
            externalAngle = ExteriorAngles(InputSides);

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalInteriorAngleSum(int InputSides)
    {
        try
        {
            interiorAngleSum = CalInteralAngle(InputSides) * InputSides;

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalExteriorAngleSum(int InputSides)
    {
        try
        {
            exteriorAngleSum = CalExternalAngle(InputSides) * InputSides;
            

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }
    public int CalPolygonCoordinates(double InputRadius, int InputSides)
    {
        try
        {
            coordinates = CalculateCoordinates(InputRadius, InputSides);

            return 0; // Indicate success
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            return -1; // Indicate an error occurred
        }
    }

}
