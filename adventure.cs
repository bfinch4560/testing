using System;
using static System.Console;
using System.Collections.Generic;
class adventure
{
    static void Main()
    {
        int health = 100;
        int karma = 50;
        int hunger = 70;
        int cinnamonRollCount = 3;
        bool cinnamonRollsLooted = false;
        string location = "";
        List<string> validLocations = new List<string> { "spawn", "kitchen" };

        WriteLine("You awake in a cave. As you begin to rise, you notice a waft of something sweet hit your nose. It seems to be coming to your left, through a shallow entrance.");
        Write('\n');
        WriteLine("Do you follow your nose? (Yes/Y or No/N)");
        string input = ReadLine();
        /* list of valid inputs for the spawn area in the beginning */
        List<string> validSpawnInput1 = new List<string> { "Yes", "yes", "Y", "y" };
        List<string> validSpawnInput2 = new List<string> { "No", "no", "N", "n" };
        if (validSpawnInput1.Contains(input))
        {
            location = "kitchen";
            cinnamonRollCount = 3;
            WriteLine("You duck through the entrance and are greeted with a small room that resembles a primitive kitchen. A small fire burns under a pot. No one seems to be around..." + '\n' +
            "However you immediately eye what was taunting your nose just prior. A small group of innocent, fluffy and sweet cinnamon rolls sits atop a rock counter.  (@) (@) (@) (<-- cinnamon rolls)" + '\n' +
            "No one seems to be around, and they are only a couple feet away.  What do you do?");
            WriteLine("To grab a cinnamon roll type grab. Otherwise, type leave.");
            string cinnamonRollInput = ReadLine();
            List<string> validCinnamonRollInput = new List<string> { "grab", "leave" };
            while (cinnamonRollInput == "grab")
            {
                if (cinnamonRollCount > 0)
                {
                    --cinnamonRollCount;
                    hunger = hunger - 5;
                    karma = karma - 10;
                    cinnamonRollsLooted = true;
                    WriteLine("You grab one cinnamon roll and quickly eat it. While it partially satiates you, you can't help but feel a little guilty. Number of cinnamon rolls left: {0}", cinnamonRollCount);
                    WriteLine("***Hunger decreased by 5 to {0}. Karma decreased by 10 to {1}***", hunger, karma);
                    WriteLine("What would you like to do now? Grab another or leave (grab/leave)");
                    cinnamonRollInput = ReadLine();
                }
                else if (cinnamonRollCount == 0)
                {
                    WriteLine("There's no cinnamon rolls left. You took them all, little thieving piggy.");
                    WriteLine("Well, no sense in hanging around to see if the owner comes back. Type leave to leave the kitchen");
                    cinnamonRollInput = ReadLine();
                }

            }
            while (cinnamonRollInput == "leave")
            {
                if(cinnamonRollCount == 3)
                {
                    WriteLine("It's probably best to not touch what isn't yours.");
                    WriteLine("You exit the kitchen and return to the cave you spaw...er...found yourself in.");
                    cinnamonRollInput = "";
                    location = "spawn";
                }
                else if (cinnamonRollCount < 3)
                {
                    WriteLine("You and your sticky, thieving hands leave the crime scene and head back to the cave.");
                    location = "spawn";
                    cinnamonRollInput = "";
                }
            }
        }
        if (validSpawnInput2.Contains(input))
        {
            WriteLine("You were not deceived by the sweet scent. Surely going after something so easy would have led to your demise. However, you do notice your stomach grumble. It would be best to find food");
        }
        while(location == "spawn")
        {
            WriteLine("What would you like to do?");
            if (cinnamonRollCount > 0)
                WriteLine("If you would like to search the kitchen again, type kitchen");
            else if (cinnamonRollCount == 0)
                WriteLine("Type right to search the right portion of the cave; ");
        }
    }
}