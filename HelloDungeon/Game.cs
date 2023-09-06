using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //plater stats
        float playerMaxHealth = 0;
        float playerDmg = 0;
        string playerName = "";
        int currentScene = 0;

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
        bool gameOver = false;
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
                Console.WriteLine(prompt);

                //display all options
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);

                if (option3 !="")
                {
                Console.WriteLine("3." + option3);
                }
                

                 
                Console.WriteLine(">");
                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    if (playerChoice == "" && option3 !="")
                    {
                        continue;
                    }
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);

                    playerChoice = "";
                    Console.Clear();
                }
               
            }
            return playerChoice;
        }

        void DisplayMainMenu()
        {
            playerChoice = DisplayMenu("Would you like to continue?", "Quit", "Restart", "Continue");
            if (playerChoice == "1")
            {
                gameOver = true;
            }
            else if (playerChoice == "2")
            {
                currentScene = 0;
            }
            else if (playerChoice == "3")
            {
                return;
            }
        }
        //Stat display function player
        void DisplayStats()
        {
            Console.WriteLine("Child" + playerName);
            Console.WriteLine("Health" + playerMaxHealth);
            Console.WriteLine("Damage" + playerDmg);
        }
        void ChosenChild_Scene0()
        {
            
            //introduction
            Console.WriteLine("                             -|             |-\r\n         -|                  [-_-_-_-_-_-_-_-]                  |-\r\n         [-_-_-_-_-]          |             |          [-_-_-_-_-]\r\n          | o   o |           [  0   0   0  ]           | o   o |\r\n           |     |    -|       |           |       |-    |     |\r\n           |     |_-___-___-___-|         |-___-___-___-_|     |\r\n           |  o  ]              [    0    ]              [  o  |\r\n           |     ]   o   o   o  [ _______ ]  o   o   o   [     | ----__________\r\n_____----- |     ]              [ ||||||| ]              [     |\r\n           |     ]              [ ||||||| ]              [     |\r\n       _-_-|_____]--------------[_|||||||_]--------------[_____|-_-_\r\n      ( (__________------------_____________-------------_________) )");

            Console.WriteLine("Narrator: You are one of the children of the King of Hearts who you know as 'Karts'," +
                "you are one of the King and Kingdoms well known protectors/caretaker.");
            Console.WriteLine("You have been summoned by the King for what sounded like a small task nothing to serious.");

            while (playerChoice != "1" && playerChoice != "2")
            {
                //Player options of which character to choose
                playerChoice = DisplayMenu("Which of the Kings children are you?",
                   "Samson a strong willed, loyal undead defender of the King & Kingdom, next in line of the throne if he wishes",
                   "Melina the Archer/Hunter a Elf who is quite skilled in survival and the various beast of the wild", "");


                if (playerChoice == "1")
                {
                    //Samson is chosen character
                    Console.Clear();
                    Console.WriteLine("You deal minor dmg, but excell in taking lots of dmg and not being hit by enemy attacks");
                    playerName = samName;
                    playerMaxHealth = maxHealthSam;
                    playerDmg = dmgSam;
                    PrintPlayerStats(playerName, playerMaxHealth, playerDmg);
                }
                else if (playerChoice == "2")
                {
                    //Melina is chosen character
                    Console.Clear();
                    Console.WriteLine("You have decent dmg with the chance of striking a creatures weakpoints for extra dmg, you use a bow that takes ammo");
                    playerName = melName;
                    playerMaxHealth = maxHealthMel;
                    playerDmg = dmgMel;

                    PrintPlayerStats(playerName, playerMaxHealth, playerDmg);
                }
                else
                {
                    //invalid input
                    Console.Clear();
                    Console.WriteLine("Must type 1 or 2");
                    Console.ReadKey(true);
                }

                // King talks to player (dependent on character)
                Console.WriteLine("Narrator: You enter the throne room when you hear a voice shout at you with joy");
                if (playerName == "Samson")
                {
                    Console.WriteLine("King: Samson! My boy, how have your duties been? Helped any people lately?");

                    Console.WriteLine();
                }
                else if (playerName == "Melina")
                {
                    Console.WriteLine("King: Melina! How was your latest Hunt did you find any dangerous beast lurking near the kingdom?");

                    Console.WriteLine();
                }
                

            }
            currentScene = 1; 
            DisplayMainMenu();
            playerChoice = "";
        }
        //Scene 1 if player is samson
        void Samson_Scene1a()
        {
            while (playerChoice != "1" && playerChoice != "2")
            {
                playerChoice = DisplayMenu("Narrator: What is your choice?", "Yes sir, ive copmleted my duties and there was no one who needed my help,", "No sir, I unfortunalety could not complete my duties " +
                    "do to me assisting some of the town folk", "");
                if (playerChoice == "1")
                {
                    Console.WriteLine("King: Well done Samson! Responsible as always, you'd make a great King someday.");
                    float dmgSam = +1;
                    Console.WriteLine("Narrator: You feel as if you've grown slightly stronger from completing your duties.");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("King: NOTHING UNFORTUNEATE ABOUT IT, *The King shouts with a wide smile* caring for our people is our biggest concern you did well Samson.");
                    float maxHealthSam = +5;
                    Console.WriteLine("Narrator: You feel tougher as your chest swells with pride from helping your people.");
                }
            }
            DisplayMainMenu();
            currentScene = 2;
            Console.Clear();
        }
        //Scene 1 if player has chosen Melina
        void Melina_Scene1b()
        {
            while (playerChoice != "1" && playerChoice != "2")
            {
                playerChoice = DisplayMenu("Narrator: What is your choice?", "Yes, I discovered a beast had been trying to feast on a few of the locals in town so I put it down.", 
                    "No, well not a dangerous one there was a large beast who was lashing out at anyone that tried to get close to it." +
                    " It was jus scared so I helped it return to the forest.", "");

                if (playerChoice == "1")
                {
                    Console.WriteLine("King: Well done Melina, you've always been great with dealing with the creatures.");
                    dmgMel = +1;
                    Console.WriteLine("Narrator: You feel as if you have increased the deadliness of your arrows slightly.");
                }
                else if (playerChoice== "2")
                {
                    Console.WriteLine("King: You've always had a soft heart when it comes to misunderstood beast, good work on relocating the poor thing.");
                    maxHealthMel = +5;
                    Console.WriteLine("Narrator: You feel a warm feeling in your heart a since of pride in yourself");
                }
            }
            DisplayMainMenu();
            currentScene = 2;
            Console.Clear();
        }
        //
        void GoblinCampers_Scene2()
        {
            
            Console.WriteLine("King: The reason I called for you was to ask if you could go on the outside of the castle and handle the the small band of goblin, " +
                "I'm not asking for any harm to fall upon them just fine out if they are trying to become citizens or cause some sort of problem for the people.");

            Console.WriteLine("Narrator: As you walk through the kingdom you see many of the towns folk giving you kind smiles and " +
                "cheers of joy do to you being a important and helpful member of the kingdom.");
            Console.WriteLine("Narrator: After the long walk out of the large Kingdom of Hearts you make your way out of the gates," +
                " where you begin to approach the smoke rising from a campfire a short ways away where u believe the goblins may be.");

            Console.WriteLine("TO BE CONTINUED...");

            DisplayMainMenu();
        }
        public void Run()
        {
            while (gameOver == false)
            {
                if (currentScene == 0)
                {
                    ChosenChild_Scene0();
                }
                else if (currentScene == 1)
                {
                    if (playerName == "Samson")
                    {
                        Samson_Scene1a();
                    }
                    else if (playerName == "Melina")
                    {
                        Melina_Scene1b();
                    }
                }
                else if (currentScene == 2)
                {
                    GoblinCampers_Scene2();
                }

            }
                
                
                

        }

        
    }
}
