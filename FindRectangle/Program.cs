//1.Создайте класс Rectangle с полями длина и ширина. Добавьте методы:

//GetArea() — возвращает площадь прямоугольника.
//GetPerimeter() — возвращает периметр.
//Создайте объект класса, задайте значения и выведите результаты вычислений.

// Task#1
// Timer 15:00
// Success

using FindRectangle;


double length = 3.0;
double width = 4.0;


Rectangle rectangle = new Rectangle(length, width);


double resultArea = rectangle.GetArea(rectangle.Length, rectangle.Width);
double resultPerimetr = rectangle.GetPerimetr(rectangle.Length, rectangle.Width);


Console.WriteLine($"Area : {resultArea}");
Console.WriteLine($"Perimetr : {resultPerimetr}");
