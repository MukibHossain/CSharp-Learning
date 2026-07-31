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

// Step 1: Create Delegate
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

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");
        Console.WriteLine("3. WhatsApp");

        Console.Write("Choose Notification Method: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        NotifyUserDelegate notify = null;

        if (choice == 1)
        {
            notify = Notification.SendEmail;
        }
        else if (choice == 2)
        {
            notify = Notification.SendSMS;
        }
        else if (choice == 3)
        {
            notify = Notification.SendWhatsApp;
        }
        else
        {
            Console.WriteLine("Invalid Choice");
            return;
        }

        notify("Hello " + name + ", your hotel booking is confirmed!");
    }
}