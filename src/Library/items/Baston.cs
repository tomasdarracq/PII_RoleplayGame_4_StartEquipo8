namespace RoleplayGame.Items;


public class Baston : IAttackItem, IDefenseItem
{
    public int AttackPower { get => 20; }
    public int DefensePower { get => 10; }

}
