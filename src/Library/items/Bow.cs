namespace RoleplayGame.Items
{
    
    public class Bow: IAttackItem, IDefenseItem
    {
        public int AttackPower 
        {
            get
            {
                return 25;
            } 
        }
        public int DefensePower
        {
            get
            {
                return 5;
            }
        }
    }
}
