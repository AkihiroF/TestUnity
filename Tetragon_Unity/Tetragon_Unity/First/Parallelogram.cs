namespace Tetragon_Unity.First;

public class Parallelogram : ATetragon
{
    public Parallelogram(float a, float b, float angel) : base(a, b, angel)
    {
    }

    public override float CountPerimeter(float a, float b)
    {
        return a * 2 + b * 2;
    }

    public override float CountArea(float d1, float d2, float angle)
    {
        return d1 * d2 * (float)Math.Sin(angle);
    }
}