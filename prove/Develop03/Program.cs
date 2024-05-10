using System;

class Program
{
    static void Main(string[] args)
    {
        string sentence1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        
        Scripture myscripture = new Scripture(sentence1, reference1);
        
        string userChoice = "";

        while(userChoice != "quit")
        {   
            Console.Clear();
            Console.WriteLine(myscripture.MakeScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \"quit\" to finish");
            if(myscripture.IsCompletelyHidden)
            {
                break;
            }
            myscripture.HideWords();
            userChoice = Console.ReadLine();
        }
    }
}
