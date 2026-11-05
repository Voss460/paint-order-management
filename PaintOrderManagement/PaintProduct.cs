namespace PaintOrderManagement;
public class PaintProduct : IBuyable
{
    public readonly decimal TaxRate;
    public const decimal DefaultDiscount = 0.05m;
    public string Name {get; set;}
    public PaintType Type {get; set;}
    public PaintSpecification Specification{get; set;}
    public decimal Price{get; set;}

    public PaintProduct(
        string name, 
        PaintType type,
        PaintSpecification specification,
        decimal price,
        decimal taxRate=0.10m
    )
    {
        Name = name;
        Type = type;
        Specification = specification;
        Price = price;
        TaxRate = taxRate;
    }
    public decimal GetFinalPrice()
    {
        decimal discountedPrice = Price * (1-DefaultDiscount);
        return discountedPrice * (1+TaxRate);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}");
        Console.WriteLine($"Type: {Type}");
        Specification.DisplaySpecification();
        Console.WriteLine($"Original Price: {Price}");
        Console.WriteLine($"Final Price:{GetFinalPrice()}");
    }

    public decimal GetMaxDiscount(int rate, bool isOverridable)
    {
        if (isOverridable)
        {
            return rate/100m;
        }
        return DefaultDiscount;
    }
}