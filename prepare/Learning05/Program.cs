using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Red", 5);
        Rectangle myRectangle = new Rectangle("Blue", 3, 6);
        Circle myCircle = new Circle("Yellow", 12);

        List<Shape> myShapes = new List<Shape>();
        myShapes.Add(mySquare);
        myShapes.Add(myRectangle);
        myShapes.Add(myCircle);

        foreach (Shape myShape in myShapes)
        {
            Console.WriteLine($"{myShape.GetColor()}: {myShape.GetArea()}");
        }
    }
}