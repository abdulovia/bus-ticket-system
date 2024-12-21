namespace bus_ticket_system {public class BankCard : IPaymentMethod { 
    public string Type { get; }

    public BankCard(string type)
    {
        Type = type;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Оплата банковской картой {Type} на сумму {amount} руб.");
    }
}
}
