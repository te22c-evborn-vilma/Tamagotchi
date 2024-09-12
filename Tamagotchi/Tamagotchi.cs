public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new();
    private bool isAlive;
    public string name;

    public Tamagotchi()
    {
        isAlive = true;
    }

    public void Feed()
    {
        hunger =-3;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public void Hi() 
    {

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
        Console.WriteLine($"Hunger: {hunger}\nBoredom: {boredom}");
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