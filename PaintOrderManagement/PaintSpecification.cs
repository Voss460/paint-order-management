namespace PaintOrderManagement;

public class PaintSpecification
{
    public string Color{get; set;}
    public int SizeinLiters {get; set;}
    public PaintSpecification(string color, int sizeinLiters)
    {
        Color = color; 
        SizeinLiters = sizeinLiters;
    }

    public void DisplaySpecification()
    {
        Console.WriteLine($"Color:{Color}");
        Console.WriteLine($"Size:{SizeinLiters}");
    }
}