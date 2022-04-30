class Triangle : Shape, IShape
{
    // default constructor
    public Triangle()
    {

    }

    public Triangle(int length, int height)
    {   
        Length = length;
        Height = height;
    }
    public double Hypotenuse { get; set; }

    public double getArea()
    {
        return 0.5 * Length * Height;
    }
}

