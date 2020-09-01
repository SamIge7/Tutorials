using System;
using System.Dynamic;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();
            //player.DaysSinceLastLogin = 33;

            int days = player?.DaysSinceLastLogin ?? -1;

            //int days = player.DaysSinceLastLogin.Value;

            Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
