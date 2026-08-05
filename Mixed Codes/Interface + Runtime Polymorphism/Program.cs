//Question 2: Online Payment System (Interface + Runtime Polymorphism)
//Scenario:
//An e-commerce company supports multiple payment methods.
//Requirements:
//1.Create interface IPayment with method:
//double Pay(double amount);
//2.Implement CreditCard(2 % fee), MobileBanking(1.5 % fee and 100 Tk cashback if
//amount >= 5000), and Cash(no fee).
//3.In Main(), store all payment methods in an IPayment[] array and process a payment of
//6000 Tk using runtime polymorphism.

using System;

// Interface
interface IPayment
{
    double Pay(double amount);
}

// Credit Card
class CreditCard : IPayment
{
    public double Pay(double amount)
    {
        double fee = amount * 0.02;
        return amount + fee;
    }
}

// Mobile Banking
class MobileBanking : IPayment
{
    public double Pay(double amount)
    {
        double fee = amount * 0.015;

        if (amount >= 5000)
        {
            return amount + fee - 100;
        }

        return amount + fee;
    }
}

// Cash
class Cash : IPayment
{
    public double Pay(double amount)
    {
        return amount;
    }
}

class Program
{
    static void Main()
    {
        IPayment[] payment = new IPayment[3];

        payment[0] = new CreditCard();
        payment[1] = new MobileBanking();
        payment[2] = new Cash();

        double amount = 6000;

        foreach (IPayment p in payment)
        {
            Console.WriteLine("Final Payment: " + p.Pay(amount));
        }
    }
}