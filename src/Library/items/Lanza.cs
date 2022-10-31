namespace RoleplayGame.Items;


public class Lanza : IAttackItem, IDefenseItem
{
    public Palo palo { get; }
    public Bow arco { get; }
    public int AttackPower { get => palo.AttackPower + arco.AttackPower; }
    public int DefensePower { get => palo.DefensePower + arco.DefensePower; }


}