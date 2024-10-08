public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new() {"Hi", "Thank you"};
    private bool isAlive;
    public string name;

    public Tamagotchi()
    {
        isAlive = true;
    }
    public void Feed()
    {
        int foodPoints = Random.Shared.Next(2,5);
        Console.WriteLine($"{name} eats");
        
        hunger = hunger - foodPoints;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }
    public void Hi() 
    {
        int wordNumber = Random.Shared.Next(words.Count);
        Console.WriteLine($"{name} says {words[wordNumber]}");
        ReduceBoredom();
    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
    public void PrintStats()
    {
        Console.WriteLine($"{name} - Hunger: {hunger} || Boredom: {boredom}");
    }
    public bool GetAlive()
    {
        return isAlive;
    }
    private void ReduceBoredom()
    {
        boredom =- 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }
}