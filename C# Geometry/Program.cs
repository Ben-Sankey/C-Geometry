// See https://aka.ms/new-console-template for more information

public struct
{
    private readonly double X;
    private readonly double Y;

    public double Latitude { get { return X; } }
    public double Longitude { get { return Y; } }

    public GeoCoordinate(double latitude, double longitude)
    {
        this.X = latitude;
        this.Y = longitude;
    }


}

class Polygon
{
    //inputs
    public int Sides = -1;
    public float Diamater = -1;
    public float Radius = -1;

    //Sides 
    public int InteralAngle = -1;
    public float ExternalAngle = -1;
    public float SideLength = -1;

    //Interiors

    //Area

    //Angles 

    //coordinates
    public coor

    public float Perimiter = -1;
    public float Area = -1;
    
    
    
    public float Apothem = -1;
    public int DiagonalCount = -1;
    public int InteriorAngleSum = -1;

}
