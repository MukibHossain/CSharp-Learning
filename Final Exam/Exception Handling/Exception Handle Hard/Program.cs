//For each scenario below, identify the matching built-in exception 
//(ArgumentException, ArgumentNullException, ArgumentOutOfRangeException, or InvalidOperationException) 
//and write code to catch and handle it:
//SetDiscount(decimal percentage) called with a negative value.
//RegisterCustomer(string name) called with name = null.
//GetItemAt(int index) called with an out-of-range index.
//ProcessPayment() called before the order's Status is "Confirmed".
using System;
class Order
{
    public string Status = "Pending";

    // 1. Negative discount
    public void SetDiscount(decimal percentage)
    {
        if (percentage < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(percentage), "Discount percentage cannot be negative.");
        }
        Console.WriteLine("Discount set to " + percentage + "%");
    }

    // 2. Null customer name
    public void RegisterCustomer(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name), "Customer name cannot be null.");
        }
        Console.WriteLine("Customer registered: " + name);
    }

    // 3. Out-of-range index
    public string GetItemAt(int index)
    {
        string[] items = { "Item1", "Item2", "Item3" };
        if (index < 0 || index >= items.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is outside the valid range of items.");
        }
        return items[index];
    }

    // 4. Wrong object state
    public void ProcessPayment()
    {
        if (Status != "Confirmed")
        {
            throw new InvalidOperationException("Cannot process payment. Order status must be 'Confirmed', but was '" + Status + "'.");
        }
        Console.WriteLine("Payment processed successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        // 1
        try { order.SetDiscount(-10); }
        catch (ArgumentOutOfRangeException ex) { Console.WriteLine("Error: " + ex.Message); }

        // 2
        try { order.RegisterCustomer(null); }
        catch (ArgumentNullException ex) { Console.WriteLine("Error: " + ex.Message); }

        // 3
        try { order.GetItemAt(10); }
        catch (ArgumentOutOfRangeException ex) { Console.WriteLine("Error: " + ex.Message); }

        // 4
        try { order.ProcessPayment(); } // Status is still "Pending"
        catch (InvalidOperationException ex) { Console.WriteLine("Error: " + ex.Message); }
    }
}