namespace bus_ticket_system;

public class ElectronicWallet : IPaymentMethod {
    public string Name { get; }

    public ElectronicWallet(string name)
    {
        Name = name;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Оплата электронным кошельком {Name} на сумму {amount} руб.");
    }
}
