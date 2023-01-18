namespace Tetragon_Unity.Second;

public class Quadrilateral : Parallelogram
{
    public new float CountArea(float d1, float d2, float angle)
    {
        return 0.5f * d1 * d2 * (float)Math.Sin(angle);
    }
}