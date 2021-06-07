﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            SmackTalkingPlayer smack = new SmackTalkingPlayer();
            smack.Name = "Duke";
            smack.Taunt = "You stink!";

            Player oneUp = new OneHigherPlayer();
            oneUp.Name = "Frank";

            Player human = new HumanPlayer();
            human.Name = "Kyle";

            human.Play(smack);

            Player sore = new SoreLoserPlayer();
            sore.Name = "Dick";

            CreativeSmackTalkingPlayer cSmack = new CreativeSmackTalkingPlayer();
            cSmack.Name = "Dave";
            cSmack.Taunts.Add("Wow, you are bad");
            cSmack.Taunts.Add("Get better!");
            cSmack.Taunts.Add("I am not having fun because you are here.");
            cSmack.Taunts.Add("You are terrible at this game of chance. Life must treat you poorly in general.");

            player3.Play(player2);

            sore.Play(human);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smack, oneUp, human, cSmack
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}