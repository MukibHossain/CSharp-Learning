//Problem 2: Hotel Booking Notification
//Question
//Create
//NotifyUserDelegate
//Methods
//Email
//SMS
//WhatsApp
//Take
//User Name
//Notification Choice
//Delegate should call the selected method.

using System;

// Step 1
delegate void NotifyUserDelegate(string message);

class Notification
{
    public static void SendEmail(string message)
    {
        Console.WriteLine("Email: " + message);
    }

    public static void SendSMS(string message)
    {
        Console.WriteLine("SMS: " + message);
    }

    public static void SendWhatsApp(string message)
    {
        Console.WriteLine("WhatsApp: " + message);
    }
}

