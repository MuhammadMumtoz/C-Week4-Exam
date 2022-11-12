public class Square : Rectangle
{
    double _side = 1.0;
    public Square() : base() { }
    public Square(double side){ 
        _side = side;
    }
    public Square(double side, Color color, bool filled) //: base(color, filled)
    {
        _side = side;
        _color = color;
        _filled = filled;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public override void SetWidth(double side)
    {
        base.SetWidth(side);
    }
    public override void SetLength(double side)
    {
        base.SetLength(side);
    }
    public override string ToString()
    {
        return $"Square[{base.ToString()}]";
    }
}
