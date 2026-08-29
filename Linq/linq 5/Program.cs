using System;
using System.Collections.Generic;

namespace PaymentSystem
{
    // Abstraction: every payment method must implement ProcessPayment().
    // New payment types can be added later just by implementing this interface,
    // without changing any existing code (Open/Closed Principle).
    interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }

    // Concrete payment type 1
    class CreditCardPayment : IPaymentMethod
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount:C} using card ending in {CardNumber.Substring(CardNumber.Length - 4)}.");
        }
    }

    // Concrete payment type 2
    class DebitCardPayment : IPaymentMethod
    {
        public string CardNumber { get; set; }

        public DebitCardPayment(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Debit Card payment of {amount:C} using card ending in {CardNumber.Substring(CardNumber.Length - 4)}.");
        }
    }

    // Concrete payment type 3
    class DigitalWalletPayment : IPaymentMethod
    {
        public string WalletId { get; set; }

        public DigitalWalletPayment(string walletId)
        {
            WalletId = walletId;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Digital Wallet payment of {amount:C} using wallet '{WalletId}'.");
        }
    }

    // A new payment type can be plugged in later with zero changes
    // to PaymentProcessor or any existing payment class.
    class BankTransferPayment : IPaymentMethod
    {
        public string AccountNumber { get; set; }

        public BankTransferPayment(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bank Transfer payment of {amount:C} from account {AccountNumber}.");
        }
    }

    // The processor depends only on the abstraction (IPaymentMethod),
    // so it never needs to change when new payment types are introduced.
    class PaymentProcessor
    {
        public void MakePayment(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();

            List<IPaymentMethod> payments = new List<IPaymentMethod>
            {
                new CreditCardPayment("1234567812345678"),
                new DebitCardPayment("8765432187654321"),
                new DigitalWalletPayment("user_wallet_001"),
                new BankTransferPayment("00998877665")
            };

            double orderAmount = 2500.00;

            Console.WriteLine("---- Processing Payments Polymorphically ----");
            foreach (IPaymentMethod payment in payments)
            {
                processor.MakePayment(payment, orderAmount);
            }
        }
    }
}

