
public class KitchenAppliance
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public string Condition { get; set; }
    public bool IsFunctioning { get; set; }
    public void Use()
    {
        Console.WriteLine("using appliance brrrr");
    }

    public KitchenAppliance(string type, string brand, string condition, bool isFunctioning)
    {
        Type = type;
        Brand = brand;
        IsFunctioning = isFunctioning;
        Condition = condition;
    }

}
