namespace bus_ticket_system;

public interface IPaymentMethod
{
    public void ProcessPayment(decimal amount);
}