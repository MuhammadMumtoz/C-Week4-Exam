
public enum Color
{
    blue,
    red,
    green,
    yellow,
    black,
    white,
    grey
};
abstract public class Shape
{

    protected Color _color;
    protected bool _filled = true;
    public Shape() { }
    public Shape(Color color, bool filled)
    {
        _color = color;
        _filled = filled;
    }
    public Color GetColor()
    {
        return _color;
    }
    public void SetColor(Color color)
    {
        _color = color;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public virtual string ToString()
    {
        return $"Shape[color={_color},filled={_filled}]";
    }
}