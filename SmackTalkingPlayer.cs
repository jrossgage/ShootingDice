using System;

namespace ShootingDice
{

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public override int Roll()
        {
            Console.WriteLine(Taunt);
            return base.Roll();
        }
    }
}