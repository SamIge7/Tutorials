using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if(string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player's name is null or all whitespace");
            }
            else
            {
                Console.WriteLine($"Player's Name : {player.Name}");
            }

            int days = player.DaysSinceLastLogin ?? -1;

            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            Console.WriteLine($"{days} days since {player.Name}'s last login");

            //if(player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine($"Days since last login: {player.DaysSinceLastLogin.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("No value for days since last login");
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No Date of Birth specified");
            }
            else
            {
                Console.WriteLine($"Date of Birth : {player.DateOfBirth}");
            }

            if(player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if(player.IsNoob == true)
            {
                Console.WriteLine("This player is a newbie");
            }
            else
            {
                Console.WriteLine("This player is an experience player");
            }
        }
    }
}
