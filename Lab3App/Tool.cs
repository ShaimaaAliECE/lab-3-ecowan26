using System.Collections.Generic;

public abstract class Tool : Collectable
{
    public abstract void DoAction();

    public override void AddMe(List<Collectable> list)
    {
        base.AddMe(list);
        DoAction();
    }
}