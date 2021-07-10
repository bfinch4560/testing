using System;
using static System.Console;
using System.Collections.Generic;
class Testing
{   
    static void Main()
    {
        int cinnamonRollCount = 3;
        while (cinnamonRollCount > 0)
        {
            WriteLine("Type 1, 2 or 3 to grab that number of cinnamon roll(s), or type leave to leave the cinnamon rolls. Number of cinnamon rolls left: {0}", cinnamonRollCount);
            int cinnamonRollsGrabbed = Convert.ToInt32(ReadLine());
            cinnamonRollCount -= cinnamonRollsGrabbed;
            List<int> validCinnamonGrabInput = new List<int> { 1, 2, 3 };
            if (validCinnamonGrabInput.Contains(cinnamonRollsGrabbed))
            {
                string interactCinnamonRollReturn = interactCinnamonRoll(cinnamonRollsGrabbed, cinnamonRollCount);
                WriteLine(interactCinnamonRollReturn);
            }
        }
    }
    private static string interactCinnamonRoll(int cinnamonRollsGrabbed, int cinnamonRollCount)
    {
        string returnString;
        if(cinnamonRollsGrabbed == 3)
        {
            WriteLine("You grabbed all the cinnamon rolls. Hungry are we?");
            returnString = "";
            return returnString;
        }
        else if (cinnamonRollCount > 1)
        {
            // cinnamonRollCount -= cinnamonRollsGrabbed;
            WriteLine("You grabbed {0} cinnamon roll(s), {1} remain.", cinnamonRollsGrabbed, cinnamonRollCount);
            returnString = "";
            return returnString;
        }
        else if (cinnamonRollCount == 1)
        {
            WriteLine("One more cinnamon roll left.");
            returnString = "";
            return returnString;
        }
        else if (cinnamonRollCount == 0)
        {
            returnString = "No more cinnamon rolls";
            return returnString;
        }
        else 
        return returnString = "something went wrong"; 
    }
}
