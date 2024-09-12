public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new();
    private bool isAlive;
    public string Name;

    
    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}\nBoredom: {boredom}");
        if (isAlive == false)
        {
            Console.WriteLine("Tamagotchi is alive");
        }
        else
        {
            Console.WriteLine("Tamagotchi is dead");
        }
    }
    public void Feed()
    {
        
    }

    public void Hi() 
    {

    }

    public void Teach(string word)
    {

    }

    public void Tick()
    {

    }

    // public bool GetAlive()
    // {

    // }

    private void ReduceBoredom()
    {

    }
}