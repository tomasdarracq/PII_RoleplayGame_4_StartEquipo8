namespace RoleplayGame.Items
{
    public class VaritaMagica : IAttackItem, IDefenseItem
    {
        public Palo palo { get; }
        public Magic magic { get; }

        public int AttackPower { get => palo.AttackPower + magic.AttackPower; }
        public int DefensePower { get => palo.DefensePower + magic.DefensePower; }

    }
}
