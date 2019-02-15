using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Shaun Wehe
             * Exercise 4
             * February 14, 2019
             * 
             * Color facts are gathered from www.thefactsite.com and azadifinerugs.com
             */
            string inputLine;
            int number;
            bool programRunning = true, firstItem = true, correctResponse = false;
            Dictionary<string, Color> colors = new Dictionary<string, Color>();
            Color tempColor = null;

            //These arrays are setup to apply to the color objects being created
            string[] red = new string[] { "The color red doesn't really make bulls angry as they are color-blind.", "Seeing the color red can make your heart beat faster.", "The word 'ruby' comes from the Latin word rubens, meaning 'red'." };
            string[] orange = new string[] { "The word orange derives from the Sanskrit naranga, and the Persian narang.", "Nobility were the only ones in the Elizabethan Era who could wear orange.", "Orange is the only word in the English language that does not have another word that rhymes with it." };
            string[] yellow = new string[] { "In Japan, yellow is the color of courage, while in Egypt, it is the color of mourning.", "Yellow is a good color to paint a room used for studying, as it has a stimulating effect on the mind.", "The idea that yellow is the easiest color to see at a distance is why warning signs are yellow... and taxis." };
            string[] green = new string[] { "Green is the national color of Ireland.", "Suicides dropped by 34% when London's Blackfiar Bridge was painted green.", "Green is the color used for night vision goggles as the human eye is most sensitive to and able to distinguish the most shades of green." };
            string[] blue = new string[] { "Studies show weight-lifters are able to handle heavier weights in blue gyms.", "Blue is the color most preferred by men.", "Owls are the only birds that can see the color blue." };
            string[] indigo = new string[] { "Indigo resides at 270 degrees between purple and blue on the color wheel.", "The color indigo is named after the indigo dye derived from the plant Indigofera tinctoria.", "It is recorded as far back as 1229 in English history that 'Indigo' was used as a color name." };
            string[] violet = new string[] { "In Japan, the color violet signifies wealth and position.", "Violet is the hardest color for the eye to distinguish.", "Dominica is the only nation on Earth to use violet in its flag." };

            //Setting up the Color objects and the dictionary
            tempColor = new Color("Red", red);
            colors.Add("Red", tempColor);
            tempColor = new Color("Orange", orange);
            colors.Add("Orange", tempColor);
            tempColor = new Color("Yellow", yellow);
            colors.Add("Yellow", tempColor);
            tempColor = new Color("Green", green);
            colors.Add("Green", tempColor);
            tempColor = new Color("Blue", blue);
            colors.Add("Blue", tempColor);
            tempColor = new Color("Indigo", indigo);
            colors.Add("Indigo", tempColor);
            tempColor = new Color("Violet", violet);
            colors.Add("Violet", tempColor);

            while (programRunning)
            {
                firstItem = true;
                correctResponse = false;
                number = 0;
                Console.Clear();
                Console.WriteLine("-COLOR FACTS-\n");
                Console.Write("What is your favorite color");
                foreach (KeyValuePair<string, Color> kvp in colors)
                {
                    number++;
                    if (firstItem)
                    {
                        Console.Write($": {number}. {kvp.Key}");
                        firstItem = false;
                    }
                    else
                    {
                        Console.Write($", {number}. {kvp.Key}");
                    }
                }
                Console.WriteLine($"?\n{colors.Count+1}. Exit\n");
                Console.Write("Selection: ");
                inputLine = Console.ReadLine().ToLower();

                if (inputLine == $"{colors.Count+1}" || inputLine == "exit")
                {
                    programRunning = false;
                    continue;
                }

                for (int i = 0; i < colors.Count; i++)
                {
                    if (inputLine == colors.ElementAt(i).Key.ToLower() || inputLine == $"{i + 1}")
                    {
                        DisplayColorFacts(colors.ElementAt(i).Value);
                        correctResponse = true;
                        break;
                    }
                }

                if (!correctResponse)
                {
                    Console.WriteLine("That is not a recognized input.\nPlease try again.\n");
                    Utility.KeyToProceed();
                }
            }

        }

        public static void DisplayColorFacts(Color input)
        {
            string[] preface = new string[] { "Did you know", "Also", "Finally" };
            
            for (int i = 0; i < input.Info.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Some facts about the color {input.Name}\n");
                Console.WriteLine($"{preface[i]}: {input.Info[i]}");
                Utility.KeyToProceed();
            }
        }
    }
}
