using System;
using System.Collections.Generic;

public class Treasure : Collectable
{
    public int Score { get; set; }

    public Treasure(string description, int score)
    {
        Description = description;
        Score = score;
    }

    public override void Display()
    {
        Console.WriteLine($"{Description} is displayed");
    }

    public void UpdateTotalScore()
    { 
        this.Board.TotalScore += this.Score;
        Console.WriteLine($"Total score is updated to: {this.Board.TotalScore}");
    }

    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
        UpdateTotalScore();
    }
}