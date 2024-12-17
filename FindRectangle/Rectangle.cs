namespace FindRectangle;

internal class Rectangle
{
    public double Length { get; set; } // Ширина
    public double Width { get; set; } // Длина


    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }



    public double GetArea(double length, double width) // S пр = Length x Width .
    {
        if(length == 0 || width == 0) return 0;

        double area = length * width;

        return area;
    }


    public double GetPerimetr(double length, double width) // P 2 x (Length + Width)
    {
        if (length == 0 || width == 0) return 0;

        double perimert = 2 * (length + width);

        return perimert;
    }
}
