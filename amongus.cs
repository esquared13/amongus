using System;

namespace amongus
{
    class Program
    {
        var sus; // will be used for inputs in the console
        string susasciiart = @"
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠯⠀⡖⠒⠒⠠⠤⣄⡀⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣷⣶⡆⣶⣶⣿⡏⣦⢁⣄⢿⣿⢰⣶⣶⡌⣿⡏⢰⣶⣦⡄⢠⠇⠀⠀⠀⠀⠀⠈⠑⢳⣦⣽⣿⢱⣶⣶⡌⣿⡇⢰⣶⣶⠈⣿⣿⣿
        ⣿⣿⣿⣿⡇⣿⣿⣿⠀⣿⢸⣿⢸⣿⠸⠿⠿⢃⣿⡇⢸⣿⣇⠂⠈⠑⠒⠦⠤⣀⡀⠀⠀⢸⣿⣿⣿⢸⣿⣿⡇⣿⡇⠈⢩⣭⣼⣿⣿⣿
        ⣿⣿⣟⣛⣃⣛⠛⣿⣅⣿⢸⣿⢸⣿⢸⣿⣿⣿⣿⣧⡘⣛⠀⠄⠀⠀⠀⠀⠀⠀⠉⢀⣶⣸⣿⣿⣿⣜⣛⣛⣡⣿⣇⣸⣷⣍⡻⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠁⠁⠱⣤⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣻⠟⢁⡇⠂⠀⠀⢻⣷⣤⣄⣀⣀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⡟⠀⣠⢧⠀⢐⡀⠀⡿⣿⣿⣿⡿⠃⣟⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⠟⠛⢉⡍⠀⠈⣽⣿⣿⣿⠒⠛⠉⠀⢳⢼⡇⠀⣇⣈⡍⢉⣄⢼⣥⡀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⠈⠀⠉⠉⠁⠀⠀⠀⠀⠀⠀⠉⠳⠿⠿⠒⠋⠁⠀⠉⠉⠉⣿⣿⣿⡛⠛⠻⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⣨⣤⣄⡠⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⠀⠀⠀⠀⠀⠀⠀⠀⢈⠉⠛⠃⠀⠀⠙⡀⠉⠻⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⠁⠀⠀⠀⢀⣶⣿⣿⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⢄⣀⣀⡀⠀⠀⠀⠀⠀⠸⣿⣿⣿⣿⣿
        ⣿⣿⡿⡟⣀⠀⠀⠀⣾⣿⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣷⣦⣀⠀⠀⠀⠀⢹⣿⣿⣿⣿
        ⣿⣿⢽⠃⠀⠓⠄⣰⣿⡍⢿⣿⣿⣦⣄⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣝⢿⣆⠀⠀⠀⣿⣿⣿⣿⣿
        ⣿⡿⢼⠀⡄⠀⢀⣿⠿⡃⠀⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⣀⣀⣀⣴⠳⣄⡀⠀⠀⠀⣀⣠⣶⣶⣾⣿⣿⣿⠛⠻⡻⣄⠀⢸⡉⢻⣿⣿⣿
        ⣿⣇⢸⡆⠇⠀⡞⠁⡕⠀⠀⠸⣿⣿⣿⣿⣿⡿⢿⡿⠛⠉⠉⠁⠈⣶⠉⠛⠛⠲⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠘⢜⡢⠀⠛⢸⣿⣿⣿
        ⣿⣿⠸⠇⠀⡄⠀⠘⠅⠀⠀⠀⠹⣿⣿⠿⣿⣄⣠⣤⡄⠀⠐⠛⠛⣿⣟⠓⠀⠀⡀⣤⣼⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⡱⠀⠀⢺⣿⣿⣿
        ⣿⣿⡆⠀⠀⠙⣄⡎⠀⠀⠀⠀⣰⣿⡻⠀⠀⢹⡟⠁⠀⠀⠀⠀⣰⣿⡇⠀⠀⠀⠀⣿⡟⢡⢿⣿⣿⡇⠀⠀⠀⠀⠀⢱⡀⠀⠀⢻⣿⣿
        ⣿⣿⡄⠀⠀⠀⠀⠻⣿⣶⣤⣤⡙⢿⣧⠐⠦⣬⣄⣀⡀⠠⠶⠒⠛⣿⠟⠁⠀⠰⢦⣿⠗⠃⣰⣿⣿⣧⠀⠀⠀⠀⠀⠘⡤⠀⠀⠀⣿⣿
        ⣿⣿⣿⣆⠀⠀⠀⠀⠙⡿⢿⣿⣿⡌⠏⣷⣤⣨⣿⠉⠀⠀⠀⠀⠀⢹⡀⠀⠀⠀⠀⣿⣧⣾⠃⣿⣿⣿⣧⡀⣠⣼⣿⡿⠁⠀⠀⢀⣿⣿
        ⣿⡏⣿⣿⣧⠀⠀⠀⠀⠀⢸⣿⣿⣿⣞⠐⠈⠻⣿⣿⣤⣀⠤⠤⠤⢿⠿⠆⠠⠶⢶⣿⡟⠀⢰⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⢠⣾⣿⣿
        ⣿⡇⣿⣯⠿⣇⠀⠀⠀⠀⢸⣿⣿⣿⣯⣯⡀⠀⠸⣿⡍⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⠇⠀⢸⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⢰⣿⣿⡿⣿
        ⣿⣧⣿⡿⡇⠙⢄⠀⠀⠀⢸⣿⣿⣿⣿⡞⣷⡀⠀⢸⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⣼⣿⣿⣿⣿⣿⣿⣟⠄⠀⠀⣼⠟⠘⢰⣿
        ⣿⣿⣾⣷⠀⠀⠀⠱⣄⡈⢸⣿⣿⣿⣿⣿⠿⠿⣦⡈⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠀⣼⠟⠿⣿⣿⣿⣿⣿⡇⢐⠀⡰⠁⠀⠀⣼⣿
        ⣿⣿⣿⣿⣧⠀⠀⠀⠹⡇⠸⣿⣿⣿⣿⠏⠀⠀⠈⣷⢻⣷⡀⠀⠀⠀⠀⠀⠀⠀⢀⡟⠀⡏⠀⠀⠘⢿⣿⣿⣿⣷⢸⡼⠁⠀⠀⣠⣿⣿
        ⣿⣿⣿⣷⣻⣷⣀⣀⣀⣃⣀⣿⣿⣿⣿⣃⣴⣎⣀⣙⣄⣻⣿⣄⣀⣀⣀⣀⣰⠄⣺⣁⣸⣇⣀⣰⣶⣈⣿⣿⣿⣿⣹⣇⣀⣀⣰⣿⣿⣿
        "; // from https://www.twitchquotes.com/copypastas/search?query=impostor titled Jacked Impostor
        string[] vents = new string[]
        {
            "admin vent","cafeteria vent","electrical vent","engines vent","medbay vent","navigation vent","o2 vent","reactor vent","security vent",
            "shields vent","weapons vent","admin vent","balcony vent","greenhouse vent","hallway vent","laboratory vent","launchpad vent",
            "medbay vent","office vent","reactor vent","o2 vent","outside vent","storage vent"

        }; // array of all of the vents in among us the hit game
        public static void Main()
        {
            while(true)
            {
                Console.WriteLine("Oh so you're the imposter? Name every vent.");
                sus = Console.ReadLine();
                if(vents.Contains(sus))
                {
                    Console.WriteLine("Maybe you are sus after all...");
                    Console.WriteLine(susasciiart);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("So...");
                    Console.WriteLine("Press any key to close the program...");
                    Console.ReadKey();
                    Console.Close();
                }
                else
                {
                    Console.WriteLine("Not funny I didn't laugh. Your joke is so bad I would have preferred the joke went over my head and you gave up re-telling me the joke. To be honest this is a horrid attempt at trying to get a laugh out of me. Not a chuckle, not a hehe, not even a subtle burst of air out of my esophagus. Science says before you laugh your brain preps your face muscles but I didn't even feel the slightest twitch. 0/10 this joke is so bad I cannot believe anyone legally allowed you to be creative at all. The amount of brain power you must have put into that joke has the potential to power every house on Earth. Get a personality and learn how to make jokes, read a book. I'm not saying this to be funny I genuinely mean it on how this is just bottom barrel embarrassment at comedy. You've single handedly killed humor and every comedic act on the planet. I'm so disappointed that society has failed as a whole in being able to teach you how to be funny. Honestly if I put in all my power and time to try and make your joke funny it would require Einstein himself to build a device to strap me into so I can be connected to the energy of a billion stars to do it, and even then all that joke would get from people is a subtle scuff. You're lucky I still have the slightest of empathy for you after telling that joke otherwise I would have committed every war crime in the book just to prevent you from attempting any humor ever again. We should put that joke in text books so future generations can be wary of becoming such an absolute comedic failure. I'm disappointed, hurt, and outright offended that my precious time has been wasted in my brain understanding that joke. In the time that took I was planning on helping kids who have been orphaned, but because of that you've wasted my time explaining the obscene integrity of your terrible attempt at comedy. Now those kids are suffering without meals and there's nobody to blame but you. I hope you're happy with what you have done and I truly hope you can move on and learn from this poor attempt.");
                }
            }
        }
    }
}