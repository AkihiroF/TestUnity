namespace Tetragon_Unity.First;

public class Square : Parallelogram
{
    public Square(float a, float b, float angel) : base(a, b, angel)
    {
    }

    public float CountPerimeter(float a)
    {
        return a * 4;
    }

    public float CountArea(float a)
    {
        return a * a;
    }
}