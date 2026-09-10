# CyberSecurityAwarenessBot-part1 

# 🔐 Cybersecurity Awareness Chatbot

## Project Overview

The Cybersecurity Awareness Chatbot is a C# console application designed to help users learn basic cybersecurity concepts. The chatbot provides simple information about common cybersecurity topics and encourages users to follow safer online practices.

The project was developed as part of Part 1 of the Cybersecurity Awareness assignment.

## Features

*  Voice greeting using a `.wav` audio file
*  Personalised interaction using the user's name
*  Interactive question-and-answer system
*  Password safety information
*  Phishing awareness
*  Safe browsing advice
*  Malware information
*  Online scam awareness
*  Two-factor authentication (2FA) information
*  Handles unknown questions with a helpful response
*  Validates empty user input
*  Allows the user to exit by typing `exit` or `quit`
*  Coloured and formatted console interface

## Technologies Used

* **C#**
* **.NET 8**
* **Visual Studio**
* **System.Media / SoundPlayer**
* **Git and GitHub**
* **GitHub Actions** for Continuous Integration (CI)

## Project Structure

```text
CyberSecurityAwarenessBot/
│
├── Audio/
│   └── greeting.wav
│
├── Bot/
│
├── chatbot.cs
├── Program.cs
├── CyberSecurityAwarenessBot.csproj
└── README.md
```

## How to Run the Application

### Requirements

Before running the application, make sure you have:

* .NET 8 SDK installed
* Visual Studio or another C# development environment
* A Windows computer, because the application uses `SoundPlayer`
* The `greeting.wav` file included in the `Audio` folder

### Running in Visual Studio

1. Clone or download the project from GitHub.
2. Open the `CyberSecurityAwarenessBot` project in Visual Studio.
3. Restore the required NuGet packages.
4. Build the solution.
5. Run the application.

The chatbot will display a welcome message and play the greeting audio.

## How to Use the Chatbot

When the chatbot starts, enter your name when prompted.

You can then ask questions about cybersecurity.

### Example Questions

```text
How are you?
What is your purpose?
What can I ask you?
Tell me about passwords
What is phishing?
What is safe browsing?
What is malware?
What is a scam?
What is 2FA?
```

The chatbot also accepts variations of some questions because it searches the user's input for relevant keywords.

To exit the chatbot, type:

```text
exit
```

or:

```text
quit
```

## Input Validation

The chatbot checks whether the user enters an empty or blank question.

If no question is entered, the chatbot displays a message asking the user to enter a question instead of continuing with invalid input.

The chatbot also provides a default response when it does not recognise the user's question.

## Voice Greeting

The application uses a `greeting.wav` audio file to provide a voice greeting when the chatbot starts.

The audio file is stored in:

```text
Audio/greeting.wav
```

The file must be available in the correct location for the voice greeting to work.

## Cybersecurity Topics

The chatbot covers several basic cybersecurity topics:

### Password Safety

Users are encouraged to use strong and unique passwords and consider using a password manager.

### Phishing

The chatbot explains that phishing involves criminals attempting to trick users into providing sensitive information through fake messages, emails or links.

### Safe Browsing

Users are advised to check website addresses, use secure websites, avoid suspicious links and avoid downloading files from unknown sources.

### Malware

The chatbot explains that malware is malicious software that can damage systems, steal information or provide unauthorised access.

### Online Scams

The chatbot explains common warning signs of scams, such as urgency and requests for money or sensitive information.

### Two-Factor Authentication

The chatbot explains how 2FA adds an additional layer of security by requiring another verification method besides a password.

## GitHub and Continuous Integration

The project is managed using Git and GitHub to track development progress.

GitHub Actions is used for Continuous Integration (CI). The workflow automatically checks the project when changes are pushed to GitHub.

This helps identify build errors early and ensures that the project remains functional as development continues.

## Learning Objectives

This project demonstrates understanding of:

* C# classes and objects
* Properties
* Methods
* Conditional statements
* Loops
* String handling
* Input validation
* Console formatting
* Basic error handling
* File and audio handling
* Git and GitHub
* Continuous Integration

## Author

**Sipho Manyenkawu**

Cybersecurity Awareness Chatbot — Part 1
