class Geometry
{
	//library to calcuate gemometry for regular 2 dimensional polygons

	//Defenitions

	// InputRadius = Measurement from cener point to any Vertex 
	// InputApothem = measurement from center point to center of a side
	// Vertex = corner of a polygon, connected to two sides 
	// Side = a line connecting two vertex points 
	// 

	//functions

	// InputApothem / InputRadius
	public static double Apothem(double InputRadius, int SideCount)
	{
        //apothem is the length from center point to center of a side formula = R cos(π/n)

        //Calculation check: 
        //InputRadius = 25
        //Side = 6 
        //InputApothem = 21.6506350946 

        double ApothemBuffer = InputRadius * Math.Cos(Math.PI / SideCount);

        return ApothemBuffer;
	}


	public static double Radius(double Apothem, int SideCount)
	{
        //radius (length from center to vertex) given the apothem = r sec(π/n) = r cos(1 / (π/n))

        //Calculation check: 
        //InputApothem = 25
        //Side = 6 
        //InputRadius = 28.8675134595

        double RadiusBuffer = Apothem * Math.Acos(1 / (Math.PI / SideCount));

        return RadiusBuffer;
	}

	public static double Diamater(double InputRadius)
	{
        //diameter is twice the radius

        //Calculation check: 
        //InputRadius = 25
        //Diamater = 50

        double DiamaterBuffer = 2 * InputRadius;

        return DiamaterBuffer;
	}

	// angles
	public static int InteriorAngles(int SideCount)
	{
        //interior angle of a regular n-sided polygon = (((n-2)/n) x 180° )

        //Calculation check: 
        //Side = 6 
        //Interior Angle = 120

        int InteriorAngleBuffer = (((SideCount - 2) / SideCount) * 180);

        return InteriorAngleBuffer;
	}

	public static int ExteriorAngles(int SideCount)
	{
        //exterior angle of a regular n-sided polygon = 360 - 360/n 

        //Calculation check: 
        //Side = 6 
        //Exterior Angle = 60

        int ExteriorAngleBuffer = 360 / SideCount;

        return ExteriorAngleBuffer;
	}

	// sides
	// side lenghth given InputApothem
	public static double SidesLengthApothem(double Apothem, int SideCount)
	{
        //side length of regular polygon given the apothem = 2r tan(π/n)

        //Calculation check: 
        //InputApothem = 25
        //Side = 6 
        //Side Lenght = 28.867513

        double SideLengthBuffer = (2 * Apothem) * Math.Tan(Math.PI / SideCount);

        return SideLengthBuffer;

	}

	// side length given InputRadius
	public static double SidesLengthRadius(double Radius, int SideCount)
	{
        //side length of regular polygon given the apothem = 2R Sin(π/n)

        //Calculation check: 
        //InputRadius = 25
        //Side = 6 
        //25

        double SideLengthBuffer = (2 * Radius) * Math.Sin(Math.PI / SideCount);

        return SideLengthBuffer;
	}

	// perimiter
	public static double Perimiter(double Measurement, int SideCount, char MeasureType)
	{
        //Perimiter = SideLength * InputSideCount

        //Calculation check: 
        //mearurment = 25
        //Side = 6 
        //Perimiter Radius: 150
        //Perimiter Apothem: 28.8675134595
        //Perimiter Side: 150

        double Perimiter = 0.0;

		switch (MeasureType)
		{

			case 'R': // InputRadius

				Perimiter = PerimiterRadius(Measurement, SideCount);

				break;

			case 'A': // InputApothem

				Perimiter = PerimiterApothem(Measurement, SideCount);

				break;


			case 'S': //Side

				Perimiter = PerimiterSide(Measurement, SideCount);

				break;
		}

		return Perimiter;

	}

	public static double PerimiterApothem(double InputApothem, int InputSideCount)
	{
        //perimiter of regular polygon from InputApothem = 2a tan(180/n) * n

        //Calculation check: 
        //InputApothem = 25
        //Side = 6 
        //Perimiter = 173.205078

        double PerimiterBuffer = SidesLengthApothem(InputApothem, InputSideCount) * InputSideCount;

        return PerimiterBuffer;

	}

	public static double PerimiterRadius(double InputRadius, int InputSideCount)
	{
        //perimiter of regular polygon from InputRadius = 2a Sin(180/n) * n

        //Calculation check: 
        //InputRadius = 25
        //Side = 6 
        //perimiter = 150

        double PerimiterBuffer = SidesLengthRadius(InputRadius, InputSideCount) * InputSideCount;

        return PerimiterBuffer;

	}

	public static double PerimiterSide(double SideLength, int SideCount)
	{
        //perimiter of regular polygon from Sides = a * n

        //Calculation check: 
        //SideLength = 25
        //Side = 6 
        //150

        double PerimiterBuffer = SideLength * SideCount;

        return PerimiterBuffer;
	}


	// area
	public static double Area(double Measurment, int SideCount, char MeasureType)
	{
        //calculates area based on specified input

        //Calculation check: 
        //Measurement = 25
        //Side = 6 
        //

        double Area = 0.0;

		switch (MeasureType)
		{

			case 'R':
				Area = AreaRadius(Measurment, SideCount);
				break;

			case 'A':
				Area = AreaApothem(Measurment, SideCount);
				break;


			case 'S':
				Area = AreaSide(Measurment, SideCount);
				break;
		}

		return Area;
	}

	// radius
	public static double AreaRadius(double Radius, int SideCount)
	{
        //to calculate the area of an n sided polygon ginven the radius (distance from center to vertex) = nr^2 tan(π/n)
        //

        //Calculation check: 
        //InputRadius = 25
        //Side = 6 
        //Area = 1623.7023693
        double ApothemBuffer = Apothem(Radius, SideCount);

        double AreaBuffer = SideCount * Math.Pow(ApothemBuffer, 2) * Math.Tan(Math.PI / SideCount);

        return AreaBuffer;

    }

	// InputApothem
	public static double AreaApothem(double Apothem, int SideCount)
	{
        //to claculate an n sided polygon given apothem (length between center and center of side) = a^2 n tan(180/n)

        //Calculation check: 
        //InputApothem = 25
        //Side = 6 
        //2165.06350946

        double AreaBuffer = SideCount * Math.Pow(Apothem, 2) * Math.Tan(Math.PI / SideCount);

        return AreaBuffer;
    }

	// side length


	public static double AreaSide(double SideLength, int SideCount)
	{
        //to calculate area of a polygon using the length of a side = (1/4)na^2

        //Calculation check: 
        //Side Length = 25
        //Side = 6 
        //937.5

        double AreaBuffer = (1/4) * SideCount * Math.Pow(SideLength, 2);

        return AreaBuffer;
	}

	public static int Diagonals(int SideCount)
	{
        //number of diagonals in a polygon = n(n-3)/2

        //Calculation check: 
        //Side = 6 
        //9

        return SideCount * (SideCount - 3) / 2;
	}

	public static double InternalTriangleArea(double Apothem, int SideCount)
	{
        //calculates the area of the triangles formed by each side and the center point of the polygon

        //Calculation check: 
        //InputApothem = 25
        //Side = 6 
        //360.75

        return Apothem * SidesLengthApothem(Apothem, SideCount) / 2;

	}

}

