namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Bow=3,
        Baston=4,
        Coraza = 5,
        Excalibur=6,
        ExcaliburOnFire=7,
        FlechaPrendidaFuego=8,
        Fuego=9,
        Gemamind = 10,
        Lanza = 11,
        Palo=12,
        PowerGem=13,
        RealityGem=14,
        spaceStone=15,
        TimeStone=16,
        VaritaMagica=17
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Bow: return new Bow();
                case ItemType.Baston: return new Baston();
                case ItemType.Coraza: return new Coraza();
                case ItemType.Excalibur: return new Excalibur();
                case ItemType.ExcaliburOnFire: return new Excaliburonfire();
                case ItemType.FlechaPrendidaFuego: return new FlechaPrendidaFuego();
                case ItemType.Fuego: return new Fuego();
                case ItemType.Gemamind: return new Gemamind();
                case ItemType.Lanza: return new Lanza();
                case ItemType.Palo: return new Palo();
                case ItemType.PowerGem: return new PowerGem();
                case ItemType.RealityGem: return new RealityGem();
                case ItemType.spaceStone: return new spaceStone();
                case ItemType.TimeStone: return new TimeStone();
                case ItemType.VaritaMagica: return new VaritaMagica();

                
                default: return null;
            }
        }
    }
}