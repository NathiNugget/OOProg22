
using System.Numerics;

double rect1x1 = 4.5;
double rect1y1 = 2.3;
double rect1x2 = 8.2;
double rect1y2 = 4.9;

double area1 = Math.Abs((rect1x1 - rect1x2) * (rect1y1 - rect1y2));
Console.WriteLine($"Area of first rectangle is {area1}");

double rect2x1 = -3.2;
double rect2y1 = 1.1;
double rect2x2 = 3.7;
double rect2y2 = 5.6;

double area2 = Math.Abs((rect2x1 - rect2x2) * (rect2y1 - rect2y2));
Console.WriteLine($"Area of second rectangle is {area2}");


double AreaOfRectangle(double x1, double y1, double x2, double y2)
{
    // Implement AreaOfRectangle, such that it returns the area
    // of a rectangle defined by (x1, y1) and (x2, y2)
    return (x1-x2)*(y1-y2);
}

area2 = AreaOfRectangle(rect2x1, rect2y1, rect2x2, rect2y2); 
Console.WriteLine($"Area of second rectangle is {area2}");

double x1 = 0;
double y1 = 0;
double x2 = 3;
double y2 = 0;
double x3 = 3.93;
double y3 = 2.85;
double x4 = 1.5;
double y4 = 4.62;
double x5 = -0.93;
double y5 = 2.85;

//double[] doubleArr1 = { x1, x2, x3, x4, x5 };
//double[] doubleArr2 = { y1, y2, y3, y4, y5 }; 

double[] doubleArr1 = { 0, 8, 10.2, 4.68, 0, -0.7 };
double[] doubleArr2 = { 0, 0, 2.85, 5.65, 2, 1.03 }; 

double Length(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 
}

Console.WriteLine($"Length of side a is: {Length(doubleArr1[0], doubleArr2[0], doubleArr1[1], doubleArr2[1])} cm");
Console.WriteLine($"Length of side a is: {Length(doubleArr1[1], doubleArr2[1], doubleArr1[2], doubleArr2[2])} cm");
Console.WriteLine($"Length of side a is: {Length(doubleArr1[2], doubleArr2[2], doubleArr1[3], doubleArr2[3])} cm");
Console.WriteLine($"Length of side a is: {Length(doubleArr1[3], doubleArr2[3], doubleArr1[4], doubleArr2[4])} cm");
Console.WriteLine($"Length of side a is: {Length(doubleArr1[4], doubleArr2[4], doubleArr1[0], doubleArr2[0])} cm");


double PerimeterOfPentagon(double[] listX, double[] listY)
{
    double sum = 0.0;
    for (global::System.Int32 i = 0; i < doubleArr1.Length; i++)
    {
        if (i == doubleArr1.Length-1)
        {
            sum += Length(doubleArr1[i], doubleArr2[i], doubleArr1[0], doubleArr2[0]); 
        }
        else
        {
            sum += Length(doubleArr1[i], doubleArr2[i], doubleArr1[i+1], doubleArr2[i+1]);
        }
    }

    return sum; 
}

Console.WriteLine($"Length of pentagon is: {PerimeterOfPentagon(doubleArr1, doubleArr2)}"); 


