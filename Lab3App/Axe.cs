using System;

public class Axe : Tool
{
    public Axe(string description)
    {
        Description = description;
    }

    public override void Display()
    {
        Console.WriteLine($"Axe {Description} is displayed");
    }

    public override void DoAction()
    {
        Console.WriteLine("Axe is Used");
    }
}