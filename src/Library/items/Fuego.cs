namespace RoleplayGame.Items
{
    
    public class Fuego: IAttackItem, IDefenseItem
    {
        public int AttackPower 
        {
            get
            {
                return 55;
            } 
        }
        public int DefensePower
        {
            get
            {
                return 1;
            }
        }
    }
}