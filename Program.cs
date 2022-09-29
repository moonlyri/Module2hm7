using Module2hm7;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length <= 0)
        {
            EAppliances[] apps = new EAppliances[5];
            apps[0] = new CoffeeMachine() { Power = 23 };
            apps[1] = new Lamp() { Power = 7 };
            apps[2] = new Computer() { Power = 0 };
            apps[3] = new Fridge() { Power = 0 };
            apps[4] = new Toaster() { Power = 13 };
            Array.Sort(apps);
        }
    }
}