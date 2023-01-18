namespace Tetragon_Unity.First;

public class Quadrilateral : ATetragon
{
    public Quadrilateral(float a, float b, float angel) : base(a, b, angel)
    {
    }

    public override float CountPerimeter(float a, float b)
    {
        return a * 2 + b * 2;
    }

    public override float CountArea(float d1, float d2, float angle)
    {
        return 0.5f * d1 * d2 * (float)Math.Sin(angle);
    }
}