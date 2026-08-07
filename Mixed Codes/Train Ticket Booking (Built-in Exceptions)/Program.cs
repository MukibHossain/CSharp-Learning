//Problem 2: Train Ticket Booking (Built-in Exceptions) 
//Scenario: A railway reservation system has 100 seats numbered from 1 to 100. 
//    A passenger enters a seat 
//number to book. 
//Requirements: 
//● Accept a seat number. 
//● Book the seat if it is available. 
using System;

class Program
{
    static void Main()
    {
        bool[] booked = new bool[101];   // Seats 1-100
        booked[50] = true;               // Seat 50 is already booked (example)

        try
        {
            Console.Write("Seat Number: ");
            int seat = Convert.ToInt32(Console.ReadLine());

            // Check seat range
            if (seat < 1 || seat > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Check if seat is already booked
            if (booked[seat])
            {
                throw new InvalidOperationException();
            }

            // Book the seat
            booked[seat] = true;
            Console.WriteLine("Seat booked successfully.");
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a numeric seat number.");
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Seat number must be between 1 and 100.");
        }

        catch (InvalidOperationException)
        {
            Console.WriteLine("The selected seat has already been booked.");
        }
    }
}