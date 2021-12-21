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
    ///<summary>private int width </summary>
    private int width;

    ///<summary>private int height </summary>
    private int height;

    /// <summary>public int Width</summary>
    public int Width {
        get
        {
            return (width);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>public property</summary>
    public int Height {
        get
        {
            return (height);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
}