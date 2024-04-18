using System;
using System.Runtime.InteropServices;
class Program
{
    const int WM_DEVICECHANGE = 0x0219;
    const int DBT_DEVICEARRIVAL = 0x8000;
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr RegisterDeviceNotification(IntPtr hRecipient, IntPtr NotificationFilter, uint Flags);
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool UnregisterDeviceNotification(IntPtr hHandle);

    static void Main(string[] args)
    {
        IntPtr notificationHandle = RegisterForUSBDeviceNotifications();
        Console.WriteLine("Waiting for USB device insertion...");

        while (true)
        {            // Wait for messages related to device changes
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
        UnregisterDeviceNotification(notificationHandle);
    }
    static IntPtr RegisterForUSBDeviceNotifications()
    {
        DEV_BROADCAST_DEVICEINTERFACE notificationFilter = new DEV_BROADCAST_DEVICEINTERFACE();
        notificationFilter.dbcc_size = (uint)Marshal.SizeOf(notificationFilter);
        notificationFilter.dbcc_devicetype = DBT_DEVTYP_DEVICEINTERFACE;
        notificationFilter.dbcc_classguid = Guid.Empty.ToByteArray();
        IntPtr hRecipient = IntPtr.Zero; // HWND_BROADCAST
        IntPtr notificationHandle = RegisterDeviceNotification(hRecipient, ref notificationFilter, 0);
        if (notificationHandle == IntPtr.Zero)
        {
            throw new Exception("Failed to register for device notifications.");
        }
        return notificationHandle;
    }
}