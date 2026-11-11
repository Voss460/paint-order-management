namespace PaintOrderManagement;
public class Order
{
    public DateTime CreatedAt {get;}
    public PaintProduct Product {get;set;}
    public int Quantity{get;set;}
    public decimal TotalPrice{get;set;}

    public Order(
        PaintProduct paintProduct, 
        int quantity
    )
    {
        Product = paintProduct;
        Quantity = quantity;
        CreatedAt = DateTime.Now;
        TotalPrice = Product.GetFinalPrice()*Quantity;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Created At: {CreatedAt}");
        Console.WriteLine($"Product: {Product.Name}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Total Price: {TotalPrice:f2}");
    }

    public decimal GetTotalPrice()
    {
        return TotalPrice;
    }
}