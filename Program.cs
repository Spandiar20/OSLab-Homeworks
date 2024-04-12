// Console.WriteLine("Hello, World!");
// int i = int.Parse(Console.ReadLine());

using System.Diagnostics;
using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]


static void Session1(){

    Console.WriteLine("Hello dude, please write what you want to do: \n \n1. To print the list of open programs.\n2. To execute a program.\n3. To kill a program");

    while (true)
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

    static void option2()
    {
        Console.WriteLine("A'ight, type the name of the Program do you want me to execute: ");
        string userInput = Console.ReadLine();
        Process.Start(userInput);
    }

    static void option3()
    {
        Process[] processes = Process.GetProcesses();
        Console.WriteLine("Here are running programs:");
        foreach (Process process in processes)
        {
            Console.WriteLine($"{process.Id}   {process.ProcessName}");
        }
        Console.WriteLine("Write down the ID of the program do you want to kill:");
        int userIndex = int.Parse(Console.ReadLine());

        foreach (Process process in processes)
        {
            if (userIndex == process.Id)
            {
                process.Kill();
                Console.WriteLine($"Process with the Id of {userIndex} has been closed!");
            }
        }
    }
}

static void Session2()
{
    const int WM_DEVICECHANGE = 0x0219;
    const int DBT_DEVICEARRIVAL = 0x8000;

    public struct DEV_BROADCAST_HDR
    {
        public uint dbch_size;
        public uint dbch_devicetype;
        public uint dbch_reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEV_BROADCAST_DEVICEINTERFACE
    {
        public uint dbcc_size;
        public uint dbcc_devicetype;
        public uint dbcc_reserved;
        public Guid dbcc_classguid;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] dbcc_name;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr RegisterDeviceNotification(IntPtr hRecipient, IntPtr NotificationFilter, uint Flags);

    static void Main(string[] args)
    {
        IntPtr notificationHandle = RegisterForUSBDeviceNotifications();

        Console.WriteLine("Waiting for USB device insertion...");

        while (true)
        {
            // Wait for messages related to device changes
            Message msg;
            if (NativeMethods.PeekMessage(out msg, IntPtr.Zero, WM_DEVICECHANGE, WM_DEVICECHANGE, 0))
            {
                // Check if it's a device arrival message
                if (msg.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                {
                    Console.WriteLine("USB device inserted.");
                }
            }
        }

        // Unregister the device notification handle when no longer needed
        NativeMethods.UnregisterDeviceNotification(notificationHandle);
    }

    static IntPtr RegisterForUSBDeviceNotifications()
    {
        DEV_BROADCAST_DEVICEINTERFACE notificationFilter = new DEV_BROADCAST_DEVICEINTERFACE();
        notificationFilter.dbcc_size = (uint)Marshal.SizeOf(notificationFilter);
        notificationFilter.dbcc_devicetype = DBT_DEVTYP_DEVICEINTERFACE;
        notificationFilter.dbcc_classguid = Guid.Empty;

        IntPtr hRecipient = IntPtr.Zero; // HWND_BROADCAST
        IntPtr notificationHandle = RegisterDeviceNotification(hRecipient, ref notificationFilter, 0);

        if (notificationHandle == IntPtr.Zero)
        {
            throw new Exception("Failed to register for device notifications.");
        }

        return notificationHandle;
    }
}
