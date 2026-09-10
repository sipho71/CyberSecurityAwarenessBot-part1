using System;

public class Chatbot
{
    // Automatic property
    public string UserName { get; set; }

    public Chatbot(string userName)
    {
        UserName = userName;
    }

    public void StartChat()
    {
        ShowWelcomeMessage();

        while (true)
        {
            Console.Write("You: ");
            string question = Console.ReadLine();

            // Input validation
            if (string.IsNullOrWhiteSpace(question))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Please enter a question.");
                Console.ResetColor();
                continue;
            }

            question = question.ToLower();

            if (question == "exit" || question == "quit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bot: Goodbye, " + UserName + "! Stay safe online.");
                Console.ResetColor();
                break;
            }

            RespondToQuestion(question);
        }
    }

    private void ShowWelcomeMessage()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("       CYBERSECURITY AWARENESS CHATBOT");
        Console.WriteLine("==============================================");

        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("Bot: Hello, " + UserName + "!");
        Console.WriteLine("Bot: I am here to help you learn about cybersecurity.");
        Console.WriteLine();
        Console.WriteLine("You can ask me about:");
        Console.WriteLine("  • Password safety");
        Console.WriteLine("  • Phishing");
        Console.WriteLine("  • Safe browsing");
        Console.WriteLine("  • My purpose");
        Console.WriteLine("  • How I am doing");
        Console.WriteLine();
        Console.WriteLine("Type 'exit' to leave the chatbot.");
        Console.WriteLine();
    }

    private void RespondToQuestion(string question)
    {
        if (question.Contains("how are you"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot: I'm doing well, " + UserName +
                              "! I'm ready to help you stay safe online.");
            Console.ResetColor();
        }
        else if (question.Contains("purpose") ||
                 question.Contains("what do you do"))
        {
            Console.WriteLine("Bot: My purpose is to teach users about basic " +
                              "cybersecurity and help them recognise common online threats.");
        }
        else if (question.Contains("what can i ask") ||
                 question.Contains("what can i ask you"))
        {
            Console.WriteLine("Bot: You can ask me about password safety, phishing, " +
                              "safe browsing, or general cybersecurity.");
        }
        else if (question.Contains("password"))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bot: Use a strong and unique password for each account. " +
                              "Use a mixture of uppercase and lowercase letters, numbers and symbols. " +
                              "A password manager can also help you manage your passwords.");
            Console.ResetColor();
        }
        else if (question.Contains("phishing"))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bot: Phishing is a scam where criminals try to trick you " +
                              "into revealing sensitive information such as passwords or banking details. " +
                              "Be careful with suspicious emails, messages and links.");
            Console.ResetColor();
        }
        else if (question.Contains("safe browsing") ||
                 question.Contains("browsing") ||
                 question.Contains("website"))
        {
            Console.WriteLine("Bot: For safer browsing, check website addresses carefully, " +
                              "look for HTTPS, avoid suspicious links and do not download files " +
                              "from unknown sources.");
        }
        else if (question.Contains("malware"))
        {
            Console.WriteLine("Bot: Malware is malicious software designed to damage systems, " +
                              "steal information or gain unauthorised access. Keep your software " +
                              "updated and use trusted security software.");
        }
        else if (question.Contains("scam"))
        {
            Console.WriteLine("Bot: Online scams try to trick people into giving away money " +
                              "or personal information. Be suspicious of messages that create urgency " +
                              "or ask for sensitive information.");
        }
        else if (question.Contains("2fa") ||
                 question.Contains("two factor") ||
                 question.Contains("multi factor"))
        {
            Console.WriteLine("Bot: Two-factor authentication adds another layer of security " +
                              "by requiring a second verification method in addition to your password.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bot: I didn't quite understand that. " +
                              "Could you please rephrase?");
            Console.ResetColor();
        }

        Console.WriteLine();
    }
}