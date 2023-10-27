﻿
// Case 1
using System.Net.Http.Headers;

Console.WriteLine("Start of Case 1");
int c1 = 1;
while (c1 < 20)
{
    Console.WriteLine(c1); // Uncomment to see result
    c1 = c1 + 2;
}
Console.WriteLine("End of Case 1");


// Case 2
Console.WriteLine("Start of Case 2");
int c2 = 1;
while (c2 < 20)
{
    Console.WriteLine(c2); // Uncomment to see result
    c2 = c2 * 2;
}
Console.WriteLine("End of Case 2");


// Case 3
Console.WriteLine("Start of Case 3");
int c3 = 15;
while ((c3 < 20) && (c3 > 10))
{
    Console.WriteLine(c3);  // Uncomment to see result
    c3++;
}
Console.WriteLine("End of Case 3");


// Case 4
Console.WriteLine("Start of Case 4");
int c4 = 10;
while (c4 >= 0)
{
    Console.WriteLine(c4);  // Uncomment to see result
    c4--;
}
Console.WriteLine("End of Case 4");


// Insert code for the below four cases
int c5 = 3;
Console.WriteLine("Start of Case 5");
while (c5 <= 9)
{
    Console.WriteLine(c5);
    c5+=2;
}
// Case 5
// Print out the numbers 3,5,7,9
Console.WriteLine("End of Case 5");


// Case 6
int c6 = 0;
Console.WriteLine("Start of Case 6");
while (c6 <= 31)
{
    Console.WriteLine(c6);
    c6 = c6 * 2 + 1; 
}
// Print out the numbers 0,1,3,7,15,31



Console.WriteLine("End of Case 6");


// Case 7
int c7 = 100; 
// Print out the numbers 100,50,25,12,6,3,1
Console.WriteLine("Start of Case 7");
while(c7 >= 1)
{
    Console.WriteLine(c7);
    c7 = (int) Math.Floor((double) c7 / 2);
}
Console.WriteLine("End of Case 7");


// Case 8 (DIFFICULT)
int c8 = 10; 
// Print out the numbers 10,9,12,7,14,5,16,3,18,1
Console.WriteLine("Start of Case 8"); 

while (c8 > 1)
{
    Console.WriteLine(c8);
    c8 = 19 + ((c8%2)*2) - c8;
}

Console.WriteLine("End of Case 8");
