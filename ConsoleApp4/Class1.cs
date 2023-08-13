using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //интерфейс оружия
    public interface WeaponBehavior
    {
        void useWeapon();
    }
    //удар мечем
    internal class KnifeBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Удар ножом");
        }
    }
    //выстрел из лука 
    internal class BowAndArrowBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Выстрел из лука");
        }
    }
    //удар топором 
    internal class AxeBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("удар топором");
        }
    }

    internal class SwordBehavior : WeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("удар мечем");
        }
    }

    abstract class Character
    {

        public  WeaponBehavior weaponBehavior;

        public void setWeapon(WeaponBehavior w)
        {
            this.weaponBehavior = w;
        }


        public abstract void Figth();
    }


    class Queen : Character
    {

        public override void Figth()
        {
           
                weaponBehavior.useWeapon();
         
        }


    }
    class King : Character
    {
        public override void Figth()
        {

            weaponBehavior.useWeapon();

        }
    }
    


}
