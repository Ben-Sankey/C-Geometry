using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Geometry
{
	//library to calcuate gemometry for regular 2 dimensional polygons

	//Defenitions

	// Radius = Measurement from cener point to any Vertex 
	// Apothem = measurement from center point to center of a side
	// Vertex = corner of a polygon, connected to two sides 
	// Side = a line connecting two vertex points 
	// 

	//functions

	// Apothem / Radius
	public static double Apothem(double InRadius, int SideCount)
	{
		//apothem is the length from center point to center of a side formula = r cos(180/n)

		return InRadius * Math.Cos(180 / SideCount);
	}


	public static double Radius(double Apothem, int SideCount)
	{
		//radius (length from center to vertex) given the apothem = a / cos(180/n)

		return Apothem / Math.Cos(180 / SideCount);
	}

	public static double Diamater(double InRadius)
	{
		//diameter is twice the radius
		return InRadius * 2;
	}

	// angles
	public static int InteriorAngles(int SideCount)
	{
		//interior angle of a regular n-sided polygon = [(n-2)180°]/n

		return ((SideCount - 2) * 180) / SideCount;
	}

	public static int ExteriorAngles(int SideCount)
	{
		//exterior angle of a regular n-sided polygon = 360/n
		return 360 / SideCount;
	}

	// sides
	// side lenghth given Apothem
	public static double SidesLengthApothem(double Apothem, int SideCount)
	{
		//side length of regular polygon given the apothem = 2a tan(180/n)

		return (2 * Apothem) * Math.Tan(180 / SideCount);

	}

	// side length given Radius
	public static double SidesLengthRadius(double Radius, int SideCount)
	{
		//side length of regular polygon given the apothem = 2R Sin(180/n)

		return (2 * Radius) * Math.Sin(180 / SideCount);
	}

	// perimiter
	public static double Perimiter(double Measurement, int SideCount, char MeasureType)
	{

		double Perimiter = 0.0;

		switch (MeasureType)
		{

			case 'R': // Radius

				Perimiter = PerimiterRadius(Measurement, SideCount);

				break;

			case 'A': // Apothem

				Perimiter = PerimiterApothem(Measurement, SideCount);

				break;


			case 'S': //Side

				Perimiter = PerimiterSide(Measurement, SideCount);

				break;
		}

		return Perimiter;

	}

	public static double PerimiterApothem(double Apothem, int SideCount)
	{
		//perimiter of regular polygon from Apothem = 2a tan(180/n) * n

		return (2 * Apothem) * Math.Tan(180 / SideCount) * SideCount;

	}

	public static double PerimiterRadius(double Radius, int SideCount)
	{
		//perimiter of regular polygon from Radius = 2a Sin(180/n) * n

		return (2 * Radius) * Math.Sin(180 / SideCount) * SideCount;

	}

	public static double PerimiterSide(double SideLength, int SideCount)
	{
		//perimiter of regular polygon from Sides = a * n
		return SideLength * SideCount;
	}


	// area
	public static double Area(double Measurment, int SideCount, char MeasureType)
	{
		//calculates area based on specified input

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
		//to calculate the area of an n sided polygon ginven the radius (distance from center to vertex) = r^2 n sin(360/n) / 2

		return Math.Pow(Radius, 2) * SideCount * Math.Sin(360 / SideCount) / 2;
	}

	// Apothem
	public static double AreaApothem(double Apothem, int SideCount)
	{
		//to claculate an n sided polygon given apothem (length between center and center of side) = a^2 n tan(180/n)

		return Math.Pow(Apothem, 2) * SideCount * Math.Tan(180 / SideCount);
	}

	// side length
	public static double AreaSide(double SideLength, int SideCount)
	{
		//to calculate area of a polygon using the length of a side = S^2 n / 4 tan(180 / n)

		return Math.Pow(SideLength, 2) * SideCount / 4 * Math.Tan(180 / SideCount);
	}

	public static int Diagonals(int SideCount)
	{
		//number of diagonals in a polygon = n(n-3)/2
		return SideCount * (SideCount - 3) / 2;
	}

	public static double InternalTriangleArea(double Apothem, int SideCount)
	{
		//calculates the area of the triangles formed by each side and the center point of the polygon

		return Apothem * SidesLengthApothem(Apothem, SideCount) / 2;

	}

}

