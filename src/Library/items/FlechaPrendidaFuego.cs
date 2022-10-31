namespace RoleplayGame.Items
{
    
    public class FlechaPrendidaFuego: IAttackItem, IDefenseItem
    {
        Bow bow = new Bow();
        Fuego fuego = new Fuego();
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