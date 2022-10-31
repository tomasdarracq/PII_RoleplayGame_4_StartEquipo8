namespace RoleplayGame.Items
{
    
    public class FlechaPrendidaFuego: IAttackItem, IDefenseItem
    {
        public Bow bow {set;get;}
        public Fuego fuego {set;get;}
        public int AttackPower 
        {
            get
            {
                return bow.AttackPower+fuego.AttackPower;
            } 
        }
        public int DefensePower
        {
            get
            {
                return bow.DefensePower+fuego.DefensePower;
            }
        }
    }
}