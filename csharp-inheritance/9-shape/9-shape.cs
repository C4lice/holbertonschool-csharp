using System;

class Shape
/// Base class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;

    private int height;

    public int Width
    /// Get or set the width of the rectangle
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException ("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    public int Height
    /// Get or set the height of the rectangle
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException ("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    public override int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

class Square : Rectangle
{
    private int size;

    public int Size
    /// Get or set the size of the square
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException ("Size must be greater than or equal to 0");
            }
            size = value;
            Height = value;
            Width = value;
        }
    }

    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    } 
}
