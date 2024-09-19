Tamagotchi myTama = new();

Console.WriteLine("Please name your Tamagotchi");
myTama.name = Console.ReadLine();

Console.WriteLine($"{myTama.name} it is");

while (myTama.GetAlive() == true)
{
    Console.Clear();
    
    myTama.PrintStats();

    Console.WriteLine("What do you want to do?");
    Console.WriteLine($"1. Teach {myTama.name} a new word");
    Console.WriteLine($"2. Talk to {myTama.name}");
    Console.WriteLine($"3. Feed {myTama.name}");
    Console.WriteLine("4. Do nothing");

    string doWhat = Console.ReadLine();

    if (doWhat == "1")
    {
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        myTama.Teach(word);
    }
    else if (doWhat == "2")
    {
        myTama.Hi();
    }
    else if (doWhat == "3")
    {
        myTama.Feed();
    }
    else 
    {
        Console.WriteLine("Not doing anything");
    }

    myTama.Tick();

    Console.WriteLine("Press enter to continue");

    Console.ReadLine();
}

Console.WriteLine($"How sad! {myTama.name} is dead!");
Console.WriteLine("Press enter to end");

Console.ReadLine();