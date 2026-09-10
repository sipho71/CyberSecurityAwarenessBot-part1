// See https://aka.ms/new-console-template for more information
using System;
using System.Media;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Cybersecurity Awareness Chatbot";

        PlayVoiceGreeting();
        DisplayAsciiLogo();

        string name = GetUserName();

        Chatbot chatbot = new Chatbot(name);
        chatbot.StartChat();
    }

    static void PlayVoiceGreeting()
    {
        string audioFile = "Audio/greeting.wav";

        try
        {
            if (File.Exists(audioFile))
            {
                SoundPlayer player = new SoundPlayer(audioFile);
                player.PlaySync();
            }
            else
            {
                Console.WriteLine("Voice greeting file was not found.");
                Console.WriteLine();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("The voice greeting could not be played.");
            Console.WriteLine();
        }
    }

    static void DisplayAsciiLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("        __________________________");
        Console.WriteLine("       |                          |");
        Console.WriteLine("       |        CYBER SAFE        |");
        Console.WriteLine("       |__________________________|");
        Console.WriteLine("              /\\");
        Console.WriteLine("             /  \\");
        Console.WriteLine("            /____\\");
        Console.WriteLine("            |    |");
        Console.WriteLine("            | [] |");
        Console.WriteLine("            |____|");
        Console.WriteLine();

        Console.ResetColor();
    }

    static string GetUserName()
    {
        string name;

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is your name? ");
            Console.ResetColor();

            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Please enter a valid name.");
                Console.ResetColor();
            }

        } while (string.IsNullOrWhiteSpace(name));

        return name.Trim();
    }
}