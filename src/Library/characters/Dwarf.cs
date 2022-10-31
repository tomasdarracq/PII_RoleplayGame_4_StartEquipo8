using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Dwarf
    /// </summary>
    public class Dwarf: Character
    {
        public Dwarf(string name)
            : base(name)
        {
            this.Health = 100;
            this.AddItem(new Coraza());
            this.AddItem(new Lanza());
        }
    }
}