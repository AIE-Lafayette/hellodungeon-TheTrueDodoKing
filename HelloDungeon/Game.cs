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
            //player character choices
            //

            //Samson the Tank/Melee (simple high defenese & hp)
            string playerName = "Samson";
            float maxHealthSam = 25;
            float dmgSam = 3;

            //Veronica the Mage/Academic

            float maxHealthVer = 15;
            float mana = 50;
            float dmgVer = 5;

            //Melina the Archer/Hunter (ammo and crit chance)

            float maxHealthMel = 20;
            float dmgMel = 7;



            //introduction
            Console.WriteLine("                             -|             |-\r\n         -|                  [-_-_-_-_-_-_-_-]                  |-\r\n         [-_-_-_-_-]          |             |          [-_-_-_-_-]\r\n          | o   o |           [  0   0   0  ]           | o   o |\r\n           |     |    -|       |           |       |-    |     |\r\n           |     |_-___-___-___-|         |-___-___-___-_|     |\r\n           |  o  ]              [    0    ]              [  o  |\r\n           |     ]   o   o   o  [ _______ ]  o   o   o   [     | ----__________\r\n_____----- |     ]              [ ||||||| ]              [     |\r\n           |     ]              [ ||||||| ]              [     |\r\n       _-_-|_____]--------------[_|||||||_]--------------[_____|-_-_\r\n      ( (__________------------_____________-------------_________) )");

            Console.WriteLine("Narrator: You are one of the children of the King of Hearts who you know as 'Karts'," +
                "you are one of the King and Kingdoms well known protectors/caretaker.");
            Console.WriteLine("You have been summoned by the King for what sounded like a small task nothing to serious.");
            Console.WriteLine("Which of the Kings children are you?");

            Console.WriteLine("");
            

        }

    }
}
