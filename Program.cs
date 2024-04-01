// Console.WriteLine("Hello, World!");
// int i = int.Parse(Console.ReadLine());

using System.Diagnostics;

Console.WriteLine("Hello dude, please write what you want to do: \n \n1. To print the list of open programs.\n2. To execute a program.\n3. To kill a program");

while(true)
{
    string userIn = Console.ReadLine();

    switch (userIn)
    {

        case "2":
            option2();
            break;

        case "3":
            option3();
            break;

        case "1":
            option1();
            break;

        default:
            Console.WriteLine("\nProgram closed with a not valid input.");
            return;

    }
}

static void option1() 
{
    Process[] procs = Process.GetProcesses();
    Console.WriteLine("Here is a list of opened and executing processes in your system:");
    foreach (Process process in procs)
    {
        Console.WriteLine($"{process.Id}   {process.ProcessName}");
    }
}

static void option2() {
    Console.WriteLine("A'ight, type the name of the Program do you want me to execute: ");
    string userInput = Console.ReadLine();
    Process.Start(userInput);
}

static void option3() {
    Process[] processes = Process.GetProcesses();
    Console.WriteLine("Here are running programs:");
    foreach (Process process in processes)
    {
        Console.WriteLine($"{process.Id}   {process.ProcessName}");
    }
    Console.WriteLine("Write down the ID of the program do you want to kill:");
    int userIndex = int.Parse(Console.ReadLine());

    foreach (Process process in processes){
        if (userIndex == process.Id)
        {
            process.Kill();
            Console.WriteLine($"Process with the Id of {userIndex} has been closed!");
        }
    }
}