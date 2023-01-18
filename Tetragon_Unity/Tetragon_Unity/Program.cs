using Tetragon_Unity.First;

namespace Tetragon_Unity;

class Program
{
    private static void Main()
    {
        var paral = new Parallelogram(12, 12, 5);
        var square = new Square(2, 2, 12);

        var squareSec = new Second.Square();
        var paralSec = new Second.Parallelogram();
        
        square.CountArea(12).Show();
        paral.CountPerimeter(12,5).Show();
        
        squareSec.CountArea(12).Show();
        squareSec.CountPerimeter(12,12).Show();
        paralSec.CountArea(10, 7,70).Show();
        paralSec.CountPerimeter(30,15).Show();
    }
}

public static class ShowInfo
{
    public static void Show(this float info) => Console.WriteLine(info);
}