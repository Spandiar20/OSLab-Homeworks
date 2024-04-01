// Console.WriteLine("Hello, World!");
// int i = int.Parse(Console.ReadLine());

using System.Diagnostics;

Console.WriteLine("Hello dude, please write what you want to do: \n \n1. To print the list of open programs.\n2. To execute a program.\n3. To kill a program");

string userIn = Console.ReadLine();

switch(userIn) {
    
    case "1":
        Console.WriteLine("A'ight, type the name of the Program do you want me to execute: ");
        userIn = Console.ReadLine();
        Process.Start(userIn);
        break;
    case "2":

}