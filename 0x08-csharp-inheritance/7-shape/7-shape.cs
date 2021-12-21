using System;
/// <summary>
/// empty class Shape
/// </summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
class Rectangle : Shape
{
    /// <summary>Private attribute width</summary>
    private int width;
    /// <summary>private attribute height</summary>
    private int height;
    /// <summary>property to get a set width value</summary>
    public int Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                this.width = value;
            }
        }
    }
    ///<sumary>property to get and set height value</sumary>
    public int Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                this.height = value;
            }
        }
    }
    /// <summary>override area method</summary>
    public override int Area()
    {
        return width * height;
    }
    public override string ToString()
    {
        return ($"[Rectangle]: {width} / {height}");
    }
}