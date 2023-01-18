namespace Tetragon_Unity;

public abstract class ATetragon
{
    protected ATetragon(float a, float b, float angel)
    {
        _a = a;
        _b = b;
        _angel = angel;
    }

    private float _a;
    private float _b;
    private float _angel;


    public abstract float CountPerimeter(float a, float b);

    public abstract float CountArea(float a, float b, float angle);
}