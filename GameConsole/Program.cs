using System;
using System.Dynamic;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Sam";
            //player.DaysSinceLastLogin = 33;

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
