using System;
using System.Dynamic;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter nicole = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Nicole"
            };

            PlayerCharacter sam = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Sam"
            };

            PlayerCharacter lewis = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Lewis"
            };

            nicole.Hit(10);
            sam.Hit(10);
            lewis.Hit(10);

            Console.ReadLine();
        }
    }
}
