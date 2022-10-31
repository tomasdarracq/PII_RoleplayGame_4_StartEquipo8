namespace RoleplayGame.Items;
using System.Collections.Generic;

public class Guante : IAttackItem
{

    public List<IAttackItem> Gems { get; private set; }
    public int AttackPower { get => this.CalculateAttackPower(); }

    private int CalculateAttackPower()
    {
        int damage = 0;
        foreach (IAttackItem gem in Gems)
        {

            damage += gem.AttackPower;

        }

        return damage;

    }
    public void AddGem(IAttackItem gem)
    {

        this.Gems.Add(gem);

    }

}