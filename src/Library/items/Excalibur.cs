using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame.Items
{
    public class Excalibur: IAttackItem,IDefenseItem
    {
         public int AttackPower 
        {
            get
            {
                return 100;
            } 
        }
        public int DefensePower
        {
            get
            {
                return 20;
            } 
        }

    }   

}