public class PixPayment : IPaymentServiceSite
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay with pix {amount}"); 
    }
}