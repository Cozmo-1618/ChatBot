//using System.Media;
using System;
using System.IO;
using NAudio.Wave; // Make sure you've installed the NuGet package!


/*Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello, Welcome to the Cybersecurity awareness Bot. i'm here to help you stay safe online!");
Console.ResetColor();*/
string soundPath = Path.Combine(Directory.GetCurrentDirectory(), "Voice Recorder.m4a");

if (File.Exists(soundPath))
{
    // AudioFileReader is "smart"—it detects the real format (MP3, WAV, etc.) automatically
    using (var audioFile = new AudioFileReader(soundPath))
    using (var outputDevice = new WaveOutEvent())
    {
        outputDevice.Init(audioFile);
        outputDevice.Play();

        Console.WriteLine("Playing voice message...");

        // Since it's a console app, we have to wait for the sound to finish
        // otherwise the program will close immediately!
        while (outputDevice.PlaybackState == PlaybackState.Playing)
        {
            System.Threading.Thread.Sleep(100);
        }
    }
}
else
{
    Console.WriteLine("Voice file not found at: " + soundPath);
}

Console.WriteLine("Please enter your name:"); 

string name = Console.ReadLine() ?? string.Empty;

//Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Hi " + name + "! Let's get started with some cybersecurity tips. Ask a question");
//Console.ResetColor();

bool continueAsking = true; 

while (continueAsking)
{

    Console.Write("\nYou: ");
    string question = Console.ReadLine()!.ToLower().Trim();
    //string answer = "";

    /*If the user types "exit", end the conversation and thank them for using the bot. 
     *Otherwise, provide answers to the questions or prompt them to ask another question.*/
    if (question == "exit")
    {
        continueAsking = false;
        Console.WriteLine("Thank you " + name + " for using the Cybersecurity awareness Bot! Stay safe online!");
        break;
    }

    //Validate user input to ensure it's not empty or just whitespace. If it is, prompt the user to enter something.
    if (string.IsNullOrWhiteSpace(question))
    {
        Console.WriteLine("Bot: Please enter something.");
        continue;
    }

    Console.WriteLine(GetRespone(question));

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=== CYBERSECURITY BOT ===");
    Console.ResetColor();

}

static string GetRespone(string question)
{

    string botAnswer = "";

    if (question == "how are you")
    {
        botAnswer = "Bot: I'm doing great, thanks for asking!";
    }
    else if (question == "whats your purpose" || question == "what is your purpose")
    {
        botAnswer = "Bot: I help you stay safe online by teaching cybersecurity tips.";
    }
    else if (question == "what can i ask you about")
    {
        botAnswer = "Bot:You can ask me about various cybersecurity topics such as common cyber threats, best practices for online safety, how to protect your personal information, and more.";
    }
    else if (question.Contains("cybersecurity"))
    {
        botAnswer = "Bot:Cybersecurity refers to the practice of protecting computers, servers, mobile devices, electronic systems, networks, and data from digital attacks. It involves implementing measures to prevent unauthorized access, data breaches, and other cyber threats.";
    }
    else if (question.Contains("password"))
    {
        botAnswer = "Bot:To create a strong password, use a combination of uppercase and lowercase letters, numbers, and special characters. Avoid using easily guessable information like birthdays or common words. Aim for a password that is at least 12 characters long.";
    }
    else if (question.Contains("phishing"))
    {
        botAnswer = "Bot:Phishing is a type of cyber attack where attackers impersonate legitimate organizations or individuals to trick victims into providing sensitive information, such as passwords or credit card numbers. To protect yourself from phishing attacks, be cautious of emails or messages that ask for personal information, and always verify the source before clicking on links or providing data.";
    }
    else if (question.Contains("two-factor authentication") || question.Contains("2fa"))
    {
        botAnswer = "Bot:Two factor authentication (2FA) is an extra layer of security that requires not only a password and username but also something that only the user has on them, such as a physical token or a mobile phone. This helps protect your accounts even if your password is compromised.";
    }
    else if (question.Contains("threats"))
    {
        botAnswer = "Bot:Some common cyber threats include malware (such as viruses and ransomware), phishing attacks, social engineering, DDoS attacks, and insider threats. It's important to be aware of these threats and take steps to protect yourself.";
    }
    else if (question.Contains("vpn"))
    {
        botAnswer = "Bot:A Virtual Private Network (VPN) is a service that encrypts your internet connection and hides your IP address, providing you with increased privacy and security online. Using a VPN on public Wi-Fi can help protect your data from potential hackers.";
    }   
    else if (question.Contains("software updates") || question.Contains("keep software updated"))
    {
        botAnswer = "Bot:Keeping your software updated is crucial for cybersecurity. Software updates often include patches for security vulnerabilities that have been discovered. By keeping your operating system, applications, and antivirus software up to date, you can protect yourself from potential cyber threats.";
    }
    else if (question.Contains("personal information") || question.Contains("protect personal information"))
    {
        botAnswer = "Bot:To protect your personal information online, be cautious about what you share on social media and other platforms. Use strong, unique passwords for your accounts, enable two-factor authentication, and be mindful of phishing attempts that may try to steal your information.";
    }
    else
    else
    {
        botAnswer = "Bot:I'm sorry, I don't have an answer for that question. Please ask another one related to cybersecurity.";
    }

    return botAnswer;

}




//Make decorative boders


/*Console.WriteLine("========================================");
Console.WriteLine("Tip 1: Use Strong Passwords");
Console.WriteLine("Use a combination of letters, numbers, and special characters to create strong passwords. Avoid using easily guessable information like birthdays or common words.");
Console.WriteLine("========================================");
Console.WriteLine("Tip 2: Enable Two-Factor Authentication");
Console.WriteLine("Enable two-factor authentication (2FA) on your accounts whenever possible. This adds an extra layer of security by requiring a second form of verification, such as a code sent to your phone.");
Console.WriteLine("========================================");
Console.WriteLine("Tip 3: Be Cautious of Phishing Scams");
Console.WriteLine("Be cautious of emails, messages, or websites that ask for personal information. Always verify the source before clicking on links or providing sensitive data.");
Console.WriteLine("========================================");
Console.WriteLine("Tip 4: Keep Software Updated");
Console.WriteLine("Keep your operating system, software, and applications updated to protect against security vulnerabilities. Enable automatic updates whenever possible.");
Console.WriteLine("========================================");
Console.WriteLine("Tip 5: Use a VPN on Public Wi-Fi");
Console.WriteLine("When using public Wi-Fi, use a Virtual Private Network (VPN) to encrypt your internet connection and protect your data from potential hackers.");
Console.WriteLine("========================================");
Console.WriteLine("Thank you " + name + " for using the Cybersecurity awareness Bot! Stay safe online!");*/



Console.ReadLine();




