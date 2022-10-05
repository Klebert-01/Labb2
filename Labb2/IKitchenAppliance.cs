
public interface IKitchenAppliance
{
    string Type { get; set; }
    string Brand { get; set; }
    string Condition { get; set; }
    bool IsFunctioning { get; set; }
    void Use();
}