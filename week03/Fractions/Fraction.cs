public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    // Constructor with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    //Properties (encapsulation)
    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Bottom
    {
        get { return _bottom; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            _bottom = value;
        }
    }
    // Method to return fraction string 
    public string GetFractionString()
    {
        return $"{_top}/ {_bottom}";
    }

    // Method to return fraction string
    public string GetFractionsString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

}
