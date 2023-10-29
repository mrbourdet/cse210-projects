using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        string scriptureChoice;
        bool choiceIsValid = false;
        string scripture="";
        string referenceIn="";
        string continueHiding;
          
        while (!choiceIsValid)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This program will help you to memorize a scripture\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose from the following scriptures: ");
            Console.ResetColor();
            Console.WriteLine("1. Old Testament - Isaiah 29:13-14");
            Console.WriteLine("2. New Testament - Ephesians 4:11-14");
            Console.WriteLine("3. Book of Mormon - 2 Nephi 9:28-29");
            Console.WriteLine("4. Doctrine and Covenants - D&C 18:15-16");
            Console.Write(">_");
            scriptureChoice = Console.ReadLine();

            switch (scriptureChoice)
            {
                case "1":
                    choiceIsValid = true;
                    scripture = "Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men:\nTherefore, behold, I will proceed to do a marvellous work among this people, even a marvellous work and a wonder: for the wisdom of their wise men shall perish, and the understanding of their prudent men shall be hid.";
                    referenceIn = "Isaiah 29:13-14";
                    break;
                case "2":
                    choiceIsValid = true;
                    scripture = "And he gave some, apostles; and some, prophets; and some, evangelists; and some, pastors and teachers;\nFor the perfecting of the saints, for the work of the ministry, for the edifying of the body of Christ:\nTill we all come in the unity of the faith, and of the knowledge of the Son of God, unto a perfect man, unto the measure of the stature of the fulness of Christ:\nThat we henceforth be no more children, tossed to and fro, and carried about with every wind of doctrine, by the sleight of men, and cunning craftiness, whereby they lie in wait to deceive;";
                    referenceIn = "Ephesians 4:11-14";
                    break;
                case "3":
                    choiceIsValid = true;
                    scripture = "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.\nBut to be learned is good if they hearken unto the counsels of God.";
                    referenceIn = "2 Nephi 9:28-29";
                    break;
                case "4":
                    choiceIsValid = true;
                    scripture = "And if it so be that you should labor all your days in crying repentance unto this people, and bring, save it be one soul unto me, how great shall be your joy with him in the kingdom of my Father!\nAnd now, if your joy will be great with one soul that you have brought unto me into the kingdom of my Father, how great will be your joy if you should bring many souls unto me!";
                    referenceIn = "D&C 18:15-16";
                    break;
                default:
                    choiceIsValid = false;
                    break;
            }
        } // End while

        Console.Clear();
        Reference chosenReference = new Reference(referenceIn); //set reference
        chosenReference.DisplayReference();

        Scripture chosenScripture = new Scripture(scripture); //set scripture
        chosenScripture.DisplayScripture();

        do
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press the enter key to hide some words, or type quit to quit.");
            Console.ResetColor();
            continueHiding = Console.ReadLine();
            Console.Clear();
            chosenScripture.Hide3Random();
            chosenReference.DisplayReference();
            Console.WriteLine();
            chosenScripture.DisplayHiddenScripture();

        }   while ((continueHiding != "quit") && !chosenScripture.AllWordsHidden());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Program Complete.");
            Console.ResetColor();
    }
    
}