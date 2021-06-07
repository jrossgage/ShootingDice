using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        public List<string> Taunts { get; set; }


        public CreativeSmackTalkingPlayer()
        {
            Taunts = new List<string>();
        }

        public override int Roll()
        {
            Random randomNumberGenerator = new Random();
            List<string> shuffledTaunts = Taunts.OrderBy(t => randomNumberGenerator.Next()).ToList();
            string randomTaunt = shuffledTaunts[0];

            Console.WriteLine(randomTaunt);
            return base.Roll();
        }

    }
}