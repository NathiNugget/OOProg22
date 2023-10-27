for (int i = 0; i < 10; i++)
{
    DrawingTool.DrawOneStar();
   
}

// SHAPE A (10 stars in a single row)
//
// **********
//

Console.WriteLine();
Console.WriteLine();


// SHAPE B (5 stars in a single row, separated by spaces)
//
// * * * * * 
//
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        DrawingTool.DrawOneStar();
    }
    else { DrawingTool.DrawOneSpace(); };
}
Console.WriteLine();
Console.WriteLine();

// SHAPE C  (10 rows of 10 stars each)
//
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
//
for (int i = 0; i < 10; i++)
{
    for (global::System.Int32 j = 0; j < 10; j++)
    {
        DrawingTool.DrawOneStar(); 
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

// SHAPE D (a triangle, I guess...)
//
// *
// **
// ***
// ****
// *****
// ******
// *******
// ********
// *********
// **********
// 

for (int i = 0; i < 10; i++)
{
    for (global::System.Int32 j = 0; j < i+1; j++)
    {
        DrawingTool.DrawOneStar();
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

// SHAPE E (X)
//
// *        *
//  *      * 
//   *    *   
//    *  *    
//     **     
//     **     
//    *  *    
//   *    *   
//  *      * 
// *        *

for (int i = 0; i < 10; i++)
{
    for (global::System.Int32 j = 0; j < 10; j++)
    {
        if (i == j)
        {
            DrawingTool.DrawOneStar();
        }
        else if (j == 10 - i-1) {
            DrawingTool.DrawOneStar();
        }
        else {
            DrawingTool.DrawOneSpace();
        }
    }
    Console.WriteLine();
}
