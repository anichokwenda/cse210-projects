// I added a code that calculates the progress in memorizing the scriptures.
using System;
using System.Globalization;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        var reference1 = new Reference("Moroni", 7, 45);
        var scriptureText1 = "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things,believeth all things, hopeth all things, endureth all things.";
        var scripture1 = new Scripture(reference1, scriptureText1);

        var reference2 = new Reference("Moroni", 10, 10, 11);
        var scriptureText2 = "And to another, that he may teach the word of knowledge by the same Spirit. And to another, exceedingly great faith; and to another,the gifts of healing by the same Spirit.";
        var scripture2 = new Scripture(reference2, scriptureText2);

        Console.WriteLine("Scripture Memorization Program");
        Console.WriteLine("---------------------");

        Scripture[] scriptures = new Scripture[] { scripture1, scripture2 };
        int currentScriptureIndex = 0;
        int totalWordsHidden = 0;
        int totalWords = scriptures.Sum(s => s.GetOriginalText().Split(' ').Length);


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scriptures[currentScriptureIndex].GetDisplayText());
            Console.WriteLine($"Progress: {totalWordsHidden} out of {totalWords} words hidden ({(double)totalWordsHidden / totalWords * 100:F2}%)");
            Console.Write("Press enter to hide words, type 'next' to switch scriptures, or type 'quit' to exit: ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine($"Final Progress:{totalWordsHidden} out of {totalWords} words hidden ({(double)totalWordsHidden / totalWords * 100:F2}%)");
                break;
            }
            else if (input.ToLower() == "next")
            {
                currentScriptureIndex = (currentScriptureIndex + 1) % scriptures.Length;
            }
            else
            {
                int wordsHidden = scriptures[currentScriptureIndex].HideRandomWords(3);
                totalWordsHidden += wordsHidden;

                if (scriptures[currentScriptureIndex].AreAllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scriptures[currentScriptureIndex].GetDisplayText());
                    Console.WriteLine("All words are hidden! Switching to the next scripture...");
                    Console.ReadLine();
                    currentScriptureIndex = (currentScriptureIndex + 1) % scriptures.Length;

                }

            }
        }

    }
}