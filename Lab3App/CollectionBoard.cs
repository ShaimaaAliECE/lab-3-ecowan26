using System.Collections.Generic;

public class CollectionBoard
{
    public int TotalScore { get; set; }
    public int TotalValue { get; set; }

    public List<Collectable> Collectables { get; private set; }

    public CollectionBoard()
    {
        Collectables = new List<Collectable>();
    }
}