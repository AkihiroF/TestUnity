namespace Tetragon_Unity.First;

public class Rectangle : Square
{
    public Rectangle(float a, float b, float angel) : base(a, b, angel)
    {
    }

    public float CountArea(float a, float b)
    {
        return a * b;
    }
}