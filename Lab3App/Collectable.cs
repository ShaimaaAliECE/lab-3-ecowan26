using System.Collections.Generic;
using System;

public abstract class Collectable : Displayable
{
    public string Description { get; set; }

    public CollectionBoard Board { get; set; }

    public virtual void AddMe(List<Collectable> list)
    {
        if (!list.Contains(this))
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }
        else
        {
            list.Remove(this);
            Console.WriteLine($"{Description} Removed.");
        }
    }

    public abstract void Display();
}