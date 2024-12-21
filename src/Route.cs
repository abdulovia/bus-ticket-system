using System;

namespace bus_ticket_system;

public class Route
{
    private static int nextId = 1;

    public int Id { get; }
    public string From { get; }
    public string To { get; }
    public DateTime DateTime { get; }
    public decimal Price { get; }

    public Route(string from, string to, DateTime dateTime, decimal price)
    {
        Id = nextId++;
        From = from;
        To = to;
        DateTime = dateTime;
        Price = price;
    }
}
