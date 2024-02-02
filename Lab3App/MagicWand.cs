using System;

public class MagicWand : Tool
{
    public MagicWand(string description)
    {
        Description = description;
    }

    public override void Display()
    {
        Console.WriteLine($"MagicWand {Description} is displayed");
    }

    public override void DoAction()
    {
        Console.WriteLine("MagicWand is Used");
    }
}