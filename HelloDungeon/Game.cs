using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //function to print player stats
        void PrintPlayerStats(string playerName, float playerMaxHealth, float playerDmg)
        {
            Console.WriteLine("Child:" + playerName);
            Console.WriteLine("Health:" + playerMaxHealth);
            Console.WriteLine("Damage:" + playerDmg);

        }
        //function for prompt and choices
        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //display prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //displat all options
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);


                Console.WriteLine(">");
                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }

            }
        }

            public void Run()
            {

                //plater stats
                //
                float playerMaxHealth = 0;
                float playerDmg = 0;
                string playerName = "";

                //Samson the Tank/Melee (simple high defenese & hp)
                string samName = "Samson";
                float maxHealthSam = 25;
                float dmgSam = 3;

                //Melina the Archer/Hunter (ammo and crit chance)
                string melName = "Melina";
                float maxHealthMel = 17;
                float dmgMel = 7;
                //
                string playerChoice = "";

                //Stat display function player

                {
                    Console.WriteLine("Child" + playerName);
                    Console.WriteLine("Health" + playerMaxHealth);
                    Console.WriteLine("Damage" + playerDmg);
                }
                //introduction
                Console.WriteLine("                             -|             |-\r\n         -|                  [-_-_-_-_-_-_-_-]                  |-\r\n         [-_-_-_-_-]          |             |          [-_-_-_-_-]\r\n          | o   o |           [  0   0   0  ]           | o   o |\r\n           |     |    -|       |           |       |-    |     |\r\n           |     |_-___-___-___-|         |-___-___-___-_|     |\r\n           |  o  ]              [    0    ]              [  o  |\r\n           |     ]   o   o   o  [ _______ ]  o   o   o   [     | ----__________\r\n_____----- |     ]              [ ||||||| ]              [     |\r\n           |     ]              [ ||||||| ]              [     |\r\n       _-_-|_____]--------------[_|||||||_]--------------[_____|-_-_\r\n      ( (__________------------_____________-------------_________) )");

                Console.WriteLine("Narrator: You are one of the children of the King of Hearts who you know as 'Karts'," +
                    "you are one of the King and Kingdoms well known protectors/caretaker.");
                Console.WriteLine("You have been summoned by the King for what sounded like a small task nothing to serious.");

                while (playerChoice != "1" && playerChoice != "2")
                {
                    Console.WriteLine("Which of the Kings children are you?");
                    //character options/description
                    Console.WriteLine("1. Samson a strong willed, loyal undead defender of the King  & Kingdom, next in line of the throne if he wishes" +
                        "        2. Melina the Archer/Hunter a Elf who is quite knowledgeable on survival and the various beast of the wild");

                    Console.Write(">");
                    playerChoice = Console.ReadLine();


                    if (playerChoice == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You deal minor dmg, but excell in taking lots of dmg and not being hit by enemy attacks");
                        playerName = samName;
                        playerMaxHealth = maxHealthSam;
                        playerDmg = dmgSam;
                        PrintPlayerStats(playerName, playerMaxHealth, playerDmg);
                    }
                    else if (playerChoice == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You have decent dmg with the chance of striking a creatures weakpoints for extra dmg, you use a bow that takes ammo");
                        playerName = melName;
                        playerMaxHealth = maxHealthMel;
                        playerDmg = dmgMel;

                        PrintPlayerStats(playerName, playerMaxHealth, playerDmg);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Must type 1 or 2");
                        Console.ReadKey(true);
                    }

                    // King talks to player
                    Console.WriteLine("Narrator: You enter the throne room when you hear a voice shout at you with joy");
                    if (playerName == "Samson")
                    {
                        Console.WriteLine("Melina! How was your latest Hunt did you find anything?");

                        Console.WriteLine();
                    }




                }

            }

        
    }
}