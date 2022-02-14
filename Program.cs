using System;
using projeto01.src.entities;

namespace projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 42, "Knight", 749, 72);
            Wizard wizard = new Wizard("Jennica", 42, "White Wizard", 574, 482);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 601, 89);
            BWizzard blackWizzard = new BWizzard("Topapa", 42, "Black Wizard", 385, 641);


            Console.WriteLine($@"
                {hero.name}
                  Lv. {hero.level} {hero.heroType}
                  HP {hero.Life()} / {hero.Hp}
                  MP {hero.Magic()} / {hero.Mp} 
                -------------------------------------------
                {wizard.name}
                  Lv. {wizard.level} {wizard.heroType}
                  HP {wizard.Life()} / {wizard.Hp}
                  MP {wizard.Magic()} / {wizard.Mp} 
                -------------------------------------------
                {ninja.name}
                  Lv. {ninja.level} {ninja.heroType}
                  HP {ninja.Life()} / {ninja.Hp}
                  MP {ninja.Magic()} / {ninja.Mp} 
                -------------------------------------------
                {blackWizzard.name}
                  Lv. {blackWizzard.level} {blackWizzard.heroType}
                  HP {blackWizzard.Life()} / {blackWizzard.Hp}
                  MP {blackWizzard.Magic()} / {blackWizzard.Mp} 
            ");
        }
    }
}
