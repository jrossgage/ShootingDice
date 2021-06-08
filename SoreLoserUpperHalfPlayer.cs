using System;

namespace ShootingDice
{

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize / 2, DiceSize + 1);
        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                    Console.WriteLine($"{int.Parse(other.Name)} Wins!");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine($"{Name} declares that the game is rigged and for children.");
                }
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }

        }

    }
}