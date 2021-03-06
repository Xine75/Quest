using System.Collections.Generic;

namespace Quest
{
    //Blueprint for an Adventurer
    public class Adventurer
    {
        // The is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        public Robe ColorfulRobe { get; }

        // A constructor to make a new Adventurer object with a given name, score and robe. Must have all 3 of these things
        public Adventurer(string name, Robe robe)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = robe;
        }

        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }

        //creates the GetDescription .method so that the program will describe the robe that is assigned to the adventurer
        //it gets the string color list from program.cs 
        public string GetDescription()
        {
            string allTheColors = "";

            foreach (string color in ColorfulRobe.Color)
            {
                allTheColors += $" {color}";
            }
            return ($"Hi, {Name}, you are wearing a gorgeous{allTheColors}-colored robe that is {ColorfulRobe.Length} inches long. Good luck on your quest!");
        }
    }
}