using System;

namespace ShootingDice
{


    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public override int Roll()
        {
            Console.Write("Enter a number for your roll. > ");
            int userInput = Console.Read();

            return userInput;

        }
    }
}