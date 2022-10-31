namespace RoleplayGame.Items
{
    public class Palo : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }

        public int DefensePower
        {
            get
            {
                return 10;
            }
        }
    }
}