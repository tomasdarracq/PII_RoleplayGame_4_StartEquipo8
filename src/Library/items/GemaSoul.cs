using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame.Items
{
    public class GemaSoul:IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 100;
            }
        }
    }
}