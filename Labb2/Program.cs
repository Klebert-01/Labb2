bool on = true;

var applianceList = new List<KitchenAppliance> { new KitchenAppliance("Waffle iron", "Bosch", true),    // lista med objekt från KitchenAppliance-klassen
                                                 new KitchenAppliance("Toaster", "LG", true),
                                                 new KitchenAppliance("Coffee maker", "Electrolux",false) };

while (on)    // MEDANS on är true körs loopen
{
    PrintOutMenu();

    int.TryParse(Console.ReadLine(), out int input);    // användarens menyval

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
            LeaveKitchen();
            break;

        default:
            Console.WriteLine("Choose between 1-5 in the menu");
            break;
    }
}


void UseAppliance()
{
    if (applianceList.Count < 1)    // om listan är tom meddelas användare och vi går ut metoden med "return"
    {
        Console.WriteLine("There is nothing in the kitchen to use.");
        return;
    }

    Console.WriteLine("What appliance do you want to use?\n");

    ListAppliancesNumbered();

    Int32.TryParse(Console.ReadLine(), out int userChoice);    // användarval

    try
    {
        if (applianceList[userChoice - 1].IsFunctioning == false)   // OM maskinen == trasig == kör kod i if-satsen,
        {
            Console.WriteLine($"The {applianceList[userChoice - 1].Type} is broken and can't be used.");
        }
        else   // ANNARS kalla på Use-metoden från KitchenAppliance-klassen
        {
            applianceList[userChoice - 1].Use();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Incorrect input\n{e}\n");
    }
    Console.WriteLine("");
}

void AddNewAppliance()
{
    string newApplianceType;    // deklarerar variabler för skapande av nytt KitchenAppliance-objekt
    string newApplianceBrand;
    bool newApplianceIsWorking;

    string yesOrNo = "";    // variabel för användarval om maskinen fungerar eller ej

    Console.Write("Type of appliance: ");   // användare får tilldela värden
    newApplianceType = Console.ReadLine();

    Console.Write("Brand: ");
    newApplianceBrand = Console.ReadLine();

    Console.Write("Is the appliance working or not? (Y/N) ");
    yesOrNo = Console.ReadLine();

    if (yesOrNo.ToUpper() == "Y")   // OM input är y eller Y, tilldela värdet true till newApplianceIsWorking
    {
        newApplianceIsWorking = true;
    }
    else if (yesOrNo.ToUpper() == "N")  // ANNARS OM input är n eller N, tilldela värdet false till newApplianceIsWorking
    {
        newApplianceIsWorking = false;
    }
    else   // ANNARS skriv ut meddelande och lämna metoden med "return"
    {
        Console.WriteLine("You need to enter Y(yes) or N(no), returning to menu.");
        return;
    }



    KitchenAppliance newAppliance = new KitchenAppliance(newApplianceType, newApplianceBrand, newApplianceIsWorking);  // Skapar nytt objekt med användarens input som parametrar

    applianceList.Add(newAppliance);   // Lägger till det nya objektet i listan

    Console.WriteLine("New appliance added to the kitchen!\n");
}

void RemoveAppliance()
{
    if (applianceList.Count < 1)   // om listan är tom meddelas användare och vi går ut metoden med "return"
    {
        Console.WriteLine("There is nothing in the kitchen to remove.");
        return;
    }

    Console.WriteLine("Choose corresponding number: ");

    ListAppliancesNumbered();

    Int32.TryParse(Console.ReadLine(), out int userChoice);    // användarinput

    try
    {
        applianceList.RemoveAt(userChoice - 1);    // Kallar på RemoveAt metoden (-1 för att hamna på rätt indexnummer)
        Console.WriteLine("Appliance removed!");
    }
    catch (Exception e)
    {
        //skriver ut instruktioner till användaren samt exception-meddelandet
        Console.WriteLine($"You need to choose a number corresponding to an appliance in the list.\n\n" +
                          $"{e}\n");
    }
}

void ListAppliances()
{
    if (applianceList.Count < 1)    // om listan är tom meddelas användare och vi går ut metoden med "return"
    {
        Console.WriteLine("The kitchen is empty.");
        return;
    }

    Console.WriteLine("Available appliances:");

    foreach (var appliance in applianceList)    // itererar genom listan av köksapparater
    {
        Console.WriteLine($"---------------------\n" +   // skriver ut typ, märke och skick för varje objekt i listan
                          $"Type: {appliance.Type}\n" +
                          $"Brand: {appliance.Brand}");

        if (appliance.IsFunctioning == true)    // OM IsFunctioning är tilldelad true, kör if-satsen
        {
            Console.WriteLine("State: Functioning");
        }
        else   // ANNARS skriv ut not functioning
        {
            Console.WriteLine("State: Not functioning");
        }
    }
    Console.WriteLine("");
}

void ListAppliancesNumbered()
{
    for (int i = 0; i < applianceList.Count; i++)   // iterera igenom längden på listan med objekt
    {
        Console.WriteLine($"{i + 1}. {applianceList[i].Type}");    // skriver ut indexnr + 1 samt typen av varje objekt i listan
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

void LeaveKitchen()
{
    Console.WriteLine("Leaving the kitchen");
    on = false;    // avslutar whileloopen/programmet
}