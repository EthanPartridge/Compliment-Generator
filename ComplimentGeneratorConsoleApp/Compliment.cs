using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplimentGeneratorConsoleApp
{
    class Compliment
    {
        private List<string> AdjectiveList = new List<string> 
        {
            "Beautiful",
            "Perfect",
            "Lovely",
            "Nice",
            "Cool",
            "Awesome",
            "Epic",
            "Radical",
            "Gnarly",
            "Sick",
            "Amazing",
            "Wonderful",
            "Sweet",
            "Good",
            "Great",
            "Incredible",
            "Huge",
            "Big",
            "Massive",
            "Absolute",
            "Astounding",
            "Encapsulating",
            "Pretty",
            "Cute",
            "Likable",
            "Marvelous",
            "Excellent",
            "Outstanding",
            "Unique",
            "Remarkable",
            "Spectacular",
            "Super",
            "Stellar",
            "Stunning",
            "Vibrant",
            "Elegant",
            "Brilliant",
            "Glowing",
            "Captivating",
            "Enchanting",
            "Magnificent",
            "Charming",
            "Dream",
            "Genuine",
            "Harmonious",
            "Inspirational",
            "Shining",
            "Clever",
            "Effortless",
            "Graceful",
            "Legendary",
            "Wholesome",
            "Adored",
            "Brilliant",
            "Dazzling",
            "Electrifying",
            "Exquisite",
            "Splendid"
        };
        private List<string> NounList = new List<string> 
        { 
            "Angel",
            "Sweetie",
            "Pumpklin", 
            "Baby",
            "Being",
            "Human",
            "Work-of-art",
            "Boss",
            "King",
            "Queen",
            "Charmer",
            "Dream",
            "Flame",
            "Spark",
            "Icon",
            "Individual",
            "Person",
            "Jewel",
            "Gem",
            "Heartthrob",
            "Inspiration",
            "Legend",
            "Pal",
            "Friend",
            "Superstar",
            "Sweetheart",
            "Light",
            "Miracle",
            "Star",
            "Soul",
            "Character",
            "Marvel",
            "Champion"
        };

        public void RandomCompliment()
        {
            Random rnd = new Random();
            int rA = rnd.Next(AdjectiveList.Count);
            int rN = rnd.Next(NounList.Count);
            string rI = $"\n{(string)AdjectiveList[rA]} {(string)NounList[rN]}";

            foreach (char c in rI) { Console.Write("-"); }
            Console.WriteLine(rI);
            foreach (char c in rI) { Console.Write("-"); }
            Console.WriteLine("\n");
            return;
        }

        public void NameCompliment(string name)
        {
            Int32.TryParse(DetermineCharacterValue(name.ToUpper()), out int nameValue);
            int nA = nameValue;
            int nN = nameValue;

            while (nA > AdjectiveList.Count())
            {
                nA -= AdjectiveList.Count();
            }
            while (nN > NounList.Count())
            {
                nN -= NounList.Count();
            }

            string nI = $"\n{(string)AdjectiveList[nA]} {(string)NounList[nN]}";

            foreach (char c in nI) { Console.Write("-"); }
            Console.WriteLine(nI);
            foreach (char c in nI) { Console.Write("-"); }
            Console.WriteLine("\n");
            return;
        }

        public void BirthdayCompliment(string birthday)
        {
            string[] sArray = birthday.Split("/");
            int bA = 0;
            int bN = 0;

            foreach (string s in sArray)
            {
                Int32.TryParse(s, out int birthdayValue);
                bA += birthdayValue;
                bN += birthdayValue;
            }

            while (bA > AdjectiveList.Count())
            {
                bA -= AdjectiveList.Count();
            }
            while (bN > NounList.Count())
            {
                bN -= NounList.Count();
            }

            string bI = $"\n{(string)AdjectiveList[bA]} {(string)NounList[bN]}";

            foreach (char c in bI) { Console.Write("-"); }
            Console.WriteLine(bI);
            foreach (char c in bI) { Console.Write("-"); }
            Console.WriteLine("\n");
            return;
        }

        public string DetermineCharacterValue(string name)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                {'A', 1},
                {'B', 4},
                {'C', 2},
                {'D', 3},
                {'E', 1},
                {'F', 5},
                {'G', 4},
                {'H', 5},
                {'I', 1},
                {'J', 7},
                {'K', 5},
                {'L', 2},
                {'M', 3},
                {'N', 2},
                {'O', 1},
                {'P', 3},
                {'Q', 8},
                {'R', 1},
                {'S', 2},
                {'T', 5},
                {'U', 5},
                {'V', 7},
                {'W', 6},
                {'X', 7},
                {'Y', 6},
                {'Z', 5},
                {' ', 10},
                {'.', 10},
                {'-', 10}
            };

            int sum = name.Sum(c => map.TryGetValue(c, out int v) ? v : 0);
            return sum.ToString();
        }
    }
}
