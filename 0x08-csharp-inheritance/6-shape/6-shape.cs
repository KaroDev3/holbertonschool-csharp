﻿using System;

/// <summary>
/// This class defines a Shape
/// </summary>
public class Shape
{
    /// <summary>
    /// method that Throws an NotImplementedException
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// This class defines a Rectangle
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }
}