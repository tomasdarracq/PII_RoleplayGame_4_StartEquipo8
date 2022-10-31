using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame.Items
{
    
    public class Excaliburonfire:IAttackItem,IDefenseItem
    {
        public Excalibur excalibur{get;set;}
        public Fuego fuego{get;set;}
    
         public int AttackPower 
        {
            get
            {
                return excalibur.AttackPower+fuego.AttackPower;
            } 
        }
        public int DefensePower
        {
            get
            {
                return excalibur.DefensePower+fuego.DefensePower;
            } 
        }
    }
   
}