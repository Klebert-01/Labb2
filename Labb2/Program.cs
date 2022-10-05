bool on = true;


var applianceList = new List<KitchenAppliance> { new KitchenAppliance("Waffle iron", "Bosch", true),
                                                 new KitchenAppliance("Toaster", "LG", true),
                                                 new KitchenAppliance("Coffee maker", "Electrolux", false) };


while (on)
{
    //kallar på menymetoden
    PrintOutMenu();

    //tar emot användarens menyval
    int.TryParse(Console.ReadLine(), out int input);

    switch (input)
    {
        case 1:

            //kod
            break;

        case 2:

            //kod
            break;

        case 3:

            //kod
            break;

        case 4:

            //kod
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

void UseAppliance()
{

}

void AddNewAppliance()
{

}

void ListAppliances()
{

}

void RemoveAppliance()
{

}