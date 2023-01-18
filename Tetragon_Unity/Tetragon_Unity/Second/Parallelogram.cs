namespace Tetragon_Unity.Second;

public class Parallelogram : ITetragon
{
    public float CountPerimeter(float a, float b)
    {
        return a * 2 + b * 2;
    }

    public float CountArea(float d1, float d2, float angle)
    {
        return d1 * d2 * (float)Math.Sin(angle);
    }
}