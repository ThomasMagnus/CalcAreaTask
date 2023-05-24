using ClassLibrary1;

Rectangle rectangle = new Rectangle(3, 4, 5);
Console.WriteLine(rectangle.CalculateSquare());

bool isRectAngular = rectangle.IsRectangular();

switch (isRectAngular)
{
    case true:
        Console.WriteLine("Треугольник прямоугольный");
        break;
    case false:
        Console.WriteLine("Треугольник не прямоугольный");
        break;
}

Circle circle = new Circle(10);
Console.WriteLine(circle.CalculateSquare());


//Задание 2

//SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
//FROM Products
//LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
//LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;