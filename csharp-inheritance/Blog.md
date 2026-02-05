Why a Square Should Not Inherit from Rectangle

In object-oriented programming, it may seem natural to say:

A square is a rectangle.

While this is mathematically true, it leads to serious design problems in software.
Implementing a Square class that inherits from Rectangle violates the Liskov Substitution Principle (LSP), one of the SOLID principles.

 The Liskov Substitution Principle (LSP)

The Liskov Substitution Principle states:

Objects of a derived class must be replaceable for objects of the base class without altering the correctness of the program.

In short, if Square inherits from Rectangle, it must behave exactly like a Rectangle in every context.

❌ The problem with Square inheriting from Rectangle
class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }
}

class Square : Rectangle
{
    public override int Width
    {
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
}

Rectangle rect = new Square();
rect.Width = 12;
rect.Height = 8;

 Unexpected behavior

Expected: 12 × 8

Actual: dimensions forced to be equal

Rectangle’s contract is broken

-> Square cannot safely replace Rectangle

-> This violates LSP

❓ Why this is bad design

Rectangle allows independent width and height

Square adds restrictive constraints

Subclasses should extend behavior, not limit it

A better class hierarchy
        Shape
       /     \
 Rectangle   Square

abstract class Shape
{
    public abstract int Area();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int Area()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public int Size { get; set; }

    public override int Area()
    {
        return Size * Size;
    }
}

Conclusion

The issue is not the square.
The issue is incorrect inheritance.

Inheritance must preserve behavior, not just logical classification.
