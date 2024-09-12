// Weapon axe = new("Axe");
// int damage = axe.Attack();
// Console.WriteLine(damage);

Tamagotchi myTama = new();

Console.WriteLine("Please name your Tamagotchi");
myTama.name = Console.ReadLine();

Console.WriteLine($"What a beautiful name {myTama.name} is");

while (myTama.GetAlive() == true)
{
    myTama.PrintStats();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine($"1. Feed {myTama.name}");
    Console.WriteLine($"2. Talk to {myTama.name}");
    Console.WriteLine($"3. Teach {myTama.name} a new word");
    Console.WriteLine("4. Do nothing");

    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {

    }
    if (doWhat == "2")
    {

    }
    if (doWhat == "3")
    {

    }
    

    myTama.Tick();
    Console.ReadLine();

}


Console.ReadLine();