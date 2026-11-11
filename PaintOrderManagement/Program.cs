namespace PaintOrderManagement;
public class Program{
    public static void Main(string[] args)
    {
        PaintSpecification spec1 = new PaintSpecification("Red", 5);
        PaintSpecification spec2 = new PaintSpecification("Orange", 10);
        PaintSpecification spec3 = new PaintSpecification("Yellow", 15);
        PaintSpecification spec4 = new PaintSpecification("White", 3);
        PaintSpecification spec5 = new PaintSpecification("Black", 7);

        PaintProduct paint1 = new PaintProduct(
            "Red Basecoat",
            PaintType.BaseCoat,
            spec1,
            50m
        );

        PaintProduct paint2 = new PaintProduct(
            "Orange Matte",
            PaintType.Matte,
            spec2,
            100m
        );

        PaintProduct paint3 = new PaintProduct(
            "Yellow Glossy",
            PaintType.Glossy,
            spec3,
            150m
        );

        PaintProduct paint4 = new PaintProduct(
            "White Basecoat",
            PaintType.BaseCoat,
            spec4,
            130m
        );

        PaintProduct paint5 = new PaintProduct(
            "Black Matte",
            PaintType.Matte,
            spec5,
            170m
        );

        Console.WriteLine("Available Products");
        paint1.DisplayInfo();
        paint2.DisplayInfo();
        paint3.DisplayInfo();
        paint4.DisplayInfo();
        paint5.DisplayInfo();

        Order order = new Order(paint1, 3);
        Console.WriteLine("Order Details");
        order.DisplayOrder();
    }
}