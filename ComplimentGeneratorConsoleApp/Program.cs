using System;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace ComplimentGeneratorConsoleApp
{
    class Program
    {
        private static bool firstRandomModeMethodCall = true;

        static void Main(string[] args)
        {
            InitializecomplimentGenerator();
        }

        public static void InitializecomplimentGenerator()
        {
            firstRandomModeMethodCall = true;
            DisplayASCIIArtTitle();
            Console.WriteLine("\nWelcome to compliment Generator!");
            Console.WriteLine("\n\tType 1 to select Randomizer Mode");
            Console.WriteLine("\tType 2 to select Name Mode");
            Console.WriteLine("\tType 3 to select Birthday Mode");
            Console.WriteLine("\tType 4 to exit the application");
            Console.Write("\nPlease type 1, 2, 3, or 4 to select a mode: ");
            string mode = Console.ReadLine();

            ModeSelection(mode);
        }
        public static void ModeSelection(string mode)
        {
            string m = "";
            int caseSwitch = 0;
            bool success = Int32.TryParse(mode, out caseSwitch);
            if (success)
            {
                switch (caseSwitch)
                {
                    case 1:
                        DisplayASCIIArtTitle(caseSwitch);
                        RandomizerMode();
                        break;
                    case 2:
                        DisplayASCIIArtTitle(caseSwitch);
                        NameMode();
                        break;
                    case 3:
                        DisplayASCIIArtTitle(caseSwitch);
                        BirthdayMode();
                        break;
                    case 4:
                        Console.WriteLine("\nGoodbye!");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nPlease type a valid number to select a mode (1, 2, 3, or 4):");
                        m = Console.ReadLine();
                        ModeSelection(m);
                        break;
                }
            }
            else
            {
                Console.Write("\nPlease type a valid number to select a mode (1, 2, 3, or 4): ");
                m = Console.ReadLine();
                ModeSelection(m);
            }
        }

        public static void RandomizerMode()
        {
            if (firstRandomModeMethodCall == true)
            {
                Console.Write("Press the ENTER key to generate a random compliment.");
                Console.ReadLine();
            }
            Compliment compliment = new Compliment();

            compliment.RandomCompliment();
            Console.WriteLine("\tType 1 to generate another compliment");
            Console.WriteLine("\tType 2 to return to mode selection");
            Console.WriteLine("\tType 3 to exit the application");
            Console.Write("\nPlease make a selection: ");
            string option = Console.ReadLine();

            firstRandomModeMethodCall = false;
            RandomizerModeOptionSelection(option);
        }
        public static void NameMode()
        {
            Console.Write("\nPlease type your name (or someone else's): ");
            string name = Console.ReadLine();
            if (name.Length <= 0) { NameMode(); }
            Compliment compliment = new Compliment();
            compliment.NameCompliment(name);

            Console.WriteLine("\tType 1 to type in another name");
            Console.WriteLine("\tType 2 to return to mode selection");
            Console.WriteLine("\tType 3 to exit the application");
            Console.Write("\nPlease make a selection: ");
            string option = Console.ReadLine();
            NameModeOptionSelection(option);
        }
        public static void BirthdayMode()
        {
            Compliment compliment = new Compliment();

            if (firstRandomModeMethodCall == true)
            {
                Console.Write("\nPlease type your birthday (or someone else's) in MM/DD/YYYY format: ");
            }
            string birthday = Console.ReadLine();
            if (DateTime.TryParse(birthday, out DateTime theDate))
            {
                compliment.BirthdayCompliment(birthday);
            }
            else
            {
                Console.Write("Please type your date in MM/DD/YYYY format (remove any symbols around date if necessary): ");
                firstRandomModeMethodCall = false;
                BirthdayMode();
            }

            firstRandomModeMethodCall = true;
            Console.WriteLine("\tType 1 to type in another name");
            Console.WriteLine("\tType 2 to return to mode selection");
            Console.WriteLine("\tType 3 to exit the application");
            Console.Write("\nPlease make a selection: ");
            string option = Console.ReadLine();
            BirthdayModeOptionSelection(option);
        }

        public static void RandomizerModeOptionSelection(string option)
        {
            string o = "";
            int caseSwitch = 0;
            bool success = Int32.TryParse(option, out caseSwitch);
            if (success)
            {
                switch (caseSwitch)
                {
                    case 1:
                        RandomizerMode();
                        break;
                    case 2:
                        InitializecomplimentGenerator();
                        break;
                    case 3:
                        Console.WriteLine("\nGoodbye!");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nPlease type a valid number to make a selection (1, 2, or 3): ");
                        o = Console.ReadLine();
                        RandomizerModeOptionSelection(o);
                        break;
                }
            }
            else
            {
                Console.Write("\nPlease type a valid number to make a selection (1, 2, or 3): ");
                o = Console.ReadLine();
                RandomizerModeOptionSelection(o);
            }
        }
        public static void NameModeOptionSelection(string option)
        {
            string o = "";
            int caseSwitch = 0;

            bool success = Int32.TryParse(option, out caseSwitch);
            if (success)
            {
                switch (caseSwitch)
                {
                    case 1:
                        NameMode();
                        break;
                    case 2:
                        InitializecomplimentGenerator();
                        break;
                    case 3:
                        Console.WriteLine("\nGoodbye!");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nPlease type a valid number to make a selection (1, 2, or 3): ");
                        o = Console.ReadLine();
                        NameModeOptionSelection(o);
                        break;
                }
            }
            else
            {
                Console.Write("\nPlease type a valid number to make a selection (1, 2, or 3): ");
                o = Console.ReadLine();
                NameModeOptionSelection(o);
            }
        }
        public static void BirthdayModeOptionSelection(string option)
        {
            string o = "";
            int caseSwitch = 0;

            bool success = Int32.TryParse(option, out caseSwitch);
            if (success)
            {
                switch (caseSwitch)
                {
                    case 1:
                        BirthdayMode();
                        break;
                    case 2:
                        InitializecomplimentGenerator();
                        break;
                    case 3:
                        Console.WriteLine("\nGoodbye!");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nPlease type a valid number to make a selection (1, 2, or 3): ");
                        o = Console.ReadLine();
                        BirthdayModeOptionSelection(o);
                        break;
                }
            }
            else
            {
                Console.Write("\nPlease type a valid number to make a selection (1, 2, or 3): ");
                o = Console.ReadLine();
                BirthdayModeOptionSelection(o);
            }
        }

        public static void DisplayASCIIArtTitle()
        {
            try
            {
                StreamReader sr = new StreamReader("ComplimentGeneratorTitleScreen.txt");
                String line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    Thread.Sleep(50);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static void DisplayASCIIArtTitle(int caseSwitch)
        {
            Console.WriteLine("\n\n\n");
            switch (caseSwitch)
            {
                case 1:
                    try
                    {
                        StreamReader sr = new StreamReader("RandomizerModeMenuScreen.txt");
                        String line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                            Thread.Sleep(50);
                        }
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        StreamReader sr = new StreamReader("NameModeMenuScreen.txt");
                        String line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                            Thread.Sleep(50);
                        }
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        StreamReader sr = new StreamReader("BirthdayModeMenuScreen.txt");
                        String line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                            Thread.Sleep(50);
                        }
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;
            }
        }
    }
}
