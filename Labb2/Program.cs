bool on = true;

//deklarera listan och lägger till några objekt av KitchenAppliance-klassen till den
var applianceList = new List<KitchenAppliance> { new KitchenAppliance("Waffle iron", "Bosch", "used", true),
                                                 new KitchenAppliance("Toaster", "LG","new", true),
                                                 new KitchenAppliance("Coffee maker", "Electrolux","used", false) };


while (on)
{
    //kallar på menymetoden
    PrintOutMenu();

    //tar emot användarens menyval
    int.TryParse(Console.ReadLine(), out int input);

    switch (input)
    {
        case 1:
            UseAppliance();
            break;

        case 2:
            AddNewAppliance();
            break;

        case 3:
            ListAppliances();
            break;

        case 4:
            RemoveAppliance();
            break;

        case 5:
            Console.WriteLine("Leaving the kitchen");
            //bool on blir false, går ur whileloopen/avslutar programmet
            on = false;
            break;

    }

}


void PrintOutMenu()
{
    Console.WriteLine("~~~~  ARVIDS KITCHEN  ~~~~\n" +
                      "[1] Use kitchen appliance\n" +
                      "[2] Add new kitchen appliance\n" +
                      "[3] List available appliances\n" +
                      "[4] Remove kitchen appliance\n" +
                      "[5] Leave the kitchen");
}

void UseAppliance()     //gå tillbaka till den här
{
    Console.WriteLine("What appliance do you want to use?\n");

    for (int i = 0; i < applianceList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {applianceList[i].Type}");
    }

}

void AddNewAppliance()
{
    Console.Write("Type of appliance: ");
    string newApplianceType = Console.ReadLine();
    Console.Write("Brand: ");
    string newApplianceBrand = Console.ReadLine();
    Console.Write("Condition (used or new) : ");    //gå tillbaka till denna kanske bool ist
    string newApplianceCondition = Console.ReadLine();

    Console.Write("Is the appliance working or not? (Y/N) ");
    bool newApplianceIsWorking;
    string yesOrNo = Console.ReadLine();

    if (yesOrNo.ToUpper() == "Y")
    {
        newApplianceIsWorking = true;
    }
    else if (yesOrNo.ToUpper() == "N")
    {
        newApplianceIsWorking = false;
    }
    else
    {
        Console.WriteLine("You need to enter Y or N");
        //return gör att vi avslutar metoden, vill egentligen fixa så den bara loopar tillbaka till nytt försök
        return;
    }
    KitchenAppliance newAppliance = new KitchenAppliance(newApplianceType, newApplianceBrand, newApplianceCondition, newApplianceIsWorking);

    applianceList.Add(newAppliance);

    Console.WriteLine("New appliance added to the kitchen!");
}

void ListAppliances()
{
    Console.WriteLine("Available appliances:");
    //itererar genom listan av köksapparater
    foreach (var appliance in applianceList)
    {
        //skriver ut typ, märke och skick för varje objekt i listan med apparater
        Console.WriteLine($"---------------------\n" +
                          $"Type: {appliance.Type}\n" +
                          $"Brand: {appliance.Brand}\n" +
                          $"Condition: {appliance.Condition}");
        //om classmember(?) IsFunctioning är satt till true, skriver ut functioning
        if (appliance.IsFunctioning == true)
            Console.WriteLine("State: Functioning");
        //annars skriv ut not functioning
        else
            Console.WriteLine("State: Not functioning");
    }
}

void RemoveAppliance()
{

}