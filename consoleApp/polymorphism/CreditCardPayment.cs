public class CreditCardPayment : IPaymentServiceSite
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay with Credit Card {amount}"); 
    }
}