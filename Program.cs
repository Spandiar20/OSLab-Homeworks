// Console.WriteLine("Hello, World!");
// int i = int.Parse(Console.ReadLine());

using System.Diagnostics;

Console.WriteLine("Hello dude, please write what you want to do: \n \n1. To print the list of open programs.\n2. To execute a program.\n3. To kill a program");

string userIn = Console.ReadLine();

switch(userIn) {
    
    case "2":
        Console.WriteLine("A'ight, type the name of the Program do you want me to execute: ");
        userIn = Console.ReadLine();
        Process.Start(userIn);
        break;

    case "3":
        Process[] processes = Process.GetProcesses();
        Console.WriteLine("Here are running programs:");
        foreach (Process process in processes){
            Console.WriteLine($"{process.Id}   {process.ProcessName}");
        }
        Console.WriteLine("Write down the ID of the program do you want to kill:");
        int userIndex = int.Parse(Console.ReadLine());
        
        foreach(Process process in processes) {
            if (userIndex == process.Id) {
                process.Kill();
                Console.WriteLine($"Process with the Id of {userIndex} has been closed!");
            }
        }
        break;

    case "1":
        Process[] procs = Process.GetProcesses();
        Console.WriteLine("Here is a list of opened and executing processes in your system:");
        foreach(Process process in procs) {
            Console.WriteLine($"{process.Id}   {process.ProcessName}");
        }
        break;

}