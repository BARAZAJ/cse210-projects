using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        
        library.AddScripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        library.AddScripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        library.AddScripture(new Reference("Alma", 34, 9), "For it is expedient that an atonement should be made; for according to the great plan of the Eternal God there must be an atonement made, or else all mankind must unavoidably perish; yea, all are hardened; yea, all are fallen and are lost, and must perish except it be through the atonement which it is expedient should be made.");
        library.AddScripture(new Reference("2 Nephi", 31, 20), "20 Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
        library.AddScripture(new Reference("Moroni", 25, 32), "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.");
        library.AddScripture(new Reference("Helaman",5,12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        Console.WriteLine("Welcome! Press ENTER to display a random scripture. Type 'quit' to exit.");
        while (true)
        {
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Scripture randomScripture = library.GetRandomScripture();
            if (randomScripture != null)
            {
                Console.Clear();
                randomScripture.Display();
                Console.WriteLine("Press ENTER to hide a random word. Type 'quit' to exit.");

                while (true)
                {
                    var innerInput = Console.ReadLine();
                    if (innerInput.ToLower() == "quit")
                        break;

                    bool wordHidden = randomScripture.HideRandomWord();
                    if (!wordHidden)
                    {
                        Console.WriteLine("All words in this scripture are hidden!");
                        break;
                    }

                    Console.Clear();
                    randomScripture.Display();
                    Console.WriteLine("Press ENTER to hide another random word. Type 'quit' to exit.");
                }
            }
            else
            {
                Console.WriteLine("No scriptures available in the library.");
                break;
            }
        }
    }
}
