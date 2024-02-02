using System.Collections.Generic;
using System;

public class Coin : Treasure
{
    public int Value { get; private set; }

    public Coin(string description, int score, int value) : base(description, score)
    {
        Value = value;
    }

    public override void Display()
    {
        Console.WriteLine($"Coin {Description} is displayed");
    }

    public void UpdateTotalValue()
    {
        this.Board.TotalValue += this.Value;
        Console.WriteLine($"Total value is updated to: {this.Board.TotalValue}");
    }

    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
        UpdateTotalValue();
    }
}