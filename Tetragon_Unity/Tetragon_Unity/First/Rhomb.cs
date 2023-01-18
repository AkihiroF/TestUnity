namespace Tetragon_Unity.First;

public class Rhomb : Parallelogram
{
    public Rhomb(float a, float b, float angel) : base(a, b, angel)
    {
    }

    public float CountArea(float d1, float d2)
    {
        return 0.5f * d1 * d2;
    }
}