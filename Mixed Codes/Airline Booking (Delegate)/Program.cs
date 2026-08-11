//Airline Ticket Booking System (Delegates + Events) 
//Problem Statement: 
//Develop an Airline Ticket Booking System. Customers can pay using Credit Card, Debit Card, or bKash. After 
//successful payment, the system should automatically: 
//• Send the e - ticket by email 
//• Send an SMS confirmation 
//• Update seat availability 
//Requirements: 
//Part A(Delegate)
//● Define PaymentDelegate. 
//● Create:
//• CreditCardPayment(double amount)
//• DebitCardPayment(double amount)
//• BkashPayment(double amount)
//● Ask the user to enter ticket price. 
//● Ask the user to choose a payment method. 
//● Use the delegate to invoke the selected payment method. 
//Part B (Event)
//● Create a publisher class named Airline.
//● Declare an event named TicketBooked. 
//● Create subscriber methods: 
//• SendEmail()
//• SendSMS()
//• UpdateSeatAvailability()
//● Raise the event after successful payment.

using System;
delegate void PaymentDelegate(double amount);
class Payment
{
    public static void CreditCardPayment(double amount)
    {
        Console.WriteLine("Payment by Credit Card Successful.");
        Console.WriteLine("Amount Paid: " + amount);
    }

    public static void DebitCardPayment(double amount)
    {
        Console.WriteLine("Payment by Debit Card Successful.");
        Console.WriteLine("Amount Paid: " + amount);
    }

    public static void BkashPayment(double amount)
    {
        Console.WriteLine("Payment by bKash Successful.");
        Console.WriteLine("Amount Paid: " + amount);
    }
}


delegate void TicketHandler();

class Airline
{
    public event TicketHandler TicketBooked;

    public void BookTicket()
    {
        Console.WriteLine("\nTicket Payment Successful.");


        TicketBooked();
    }
}



class AirlineService
{
    public void SendEmail()
    {
        Console.WriteLine("E-ticket sent by Email.");
    }

    public void SendSMS()
    {
        Console.WriteLine("SMS confirmation sent.");
    }

    public void UpdateSeatAvailability()
    {
        Console.WriteLine("Seat availability updated.");
    }
}




