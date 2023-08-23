using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //player name
            string playerTrueName = "Insert Player";
            string playerName = "Henry";
            //player stats
            int maxHealth = 100;
            bool playerAlive = true;
            float playerCoins = 10.25f;
            int playerDmg = 1;
            float playerMana = 50.00f;


            //Introduction
            Console.WriteLine("Hello there");
            Console.WriteLine("What is your name again?");
            //player creates there name
            playerTrueName = Console.ReadLine();
            //
            Console.WriteLine(playerTrueName + " really? Thats what you chose to call your self? Why not " + playerName + "?");

            Console.WriteLine("Would you like to be renamed 'Henry'? y/n");
            Console.ReadLine();
            Console.WriteLine("Henry it is! That better isn't it? Welcome to the start of your Journey");
        }
    }
}
