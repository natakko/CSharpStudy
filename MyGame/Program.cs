using MyGame.Core;

Player player = new Player(200);

bool isBuyingProcess = true;

while (isBuyingProcess == true)
{
    Console.WriteLine("Would you like to buy some units? Y / N ?");
    string answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
        isBuyingProcess = true;
    }
    else
    {
        isBuyingProcess = false;
        break;
    }

    Console.WriteLine("*** Custom Unit Creation START ***");
    GameUnitCreator gameUnitCreator = new GameUnitCreator();

    GameUnit customUnit = gameUnitCreator.Create();
    int unitPrice = customUnit.Health + customUnit.Speed + customUnit.Armor + customUnit.Damage;

    Console.WriteLine(customUnit.GetInfo());
    Console.WriteLine($"This unit price: '{unitPrice}'");
    Console.WriteLine("*** Custom Unit Creation END ***");

    Console.WriteLine();
    Console.WriteLine($"Would you buy this unit? (Y/N) Your gold: '{player.PlayerGold}'");
    answer = Console.ReadLine().ToUpper();
    if (answer == "Y")
    {
        bool isEnoughtGold = unitPrice <= player.PlayerGold;
        if (isEnoughtGold)
        {
            player.AddUnit(customUnit, unitPrice);
        }
        else
        {
            Console.WriteLine("Gold is not enough.");
        }
    }

}

Console.WriteLine();

Console.WriteLine("Your buying result:");
foreach (GameUnit gameUnit in player.UnitsList)
{
    Console.WriteLine(gameUnit.GetInfo());
}