
public class KitchenAppliance : IKitchenAppliance   
{
    public string Type { get; set; }
    public string Brand { get; set; }

    public bool IsFunctioning { get; set; }
    public void Use()
    {
        Console.WriteLine($"using {Type}");  
    }

    public KitchenAppliance(string type, string brand, bool isFunctioning)
    {
        Type = type;
        Brand = brand;
        IsFunctioning = isFunctioning;
    }

}
