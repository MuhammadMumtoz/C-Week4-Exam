public class Rectangle:Shape{
    double _width = 1.0;
    double _length = 1.0;
    public Rectangle():base(){}
    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }
    public Rectangle(double width, double length, Color color, bool filled):base(color,filled)
    {
        _width = width;
        _length = length;
    }
    public double GetWidth(){
        return _width;
    }
    public virtual void SetWidth(double width){
        _width = width;
    }
    public double GetLength(){
        return _length;
    }
    public virtual void SetLength(double length){
        _length = length;
    }
    public override double GetArea()
    {
        return _length*_width;
    }
    public override double GetPerimeter()
    {
        return 2*(_length+_width);
    }
    public override string ToString()
    {
        return $"Rectangle[{base.ToString()},width={_width},length={_length}]";
    }
}