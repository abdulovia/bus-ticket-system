using System;

namespace bus_ticket_system;

public class Ticket
{
    public Route Route { get; } public int Quantity { get; }

    public Ticket(Route route, int quantity)
    {
        Route = route;
        Quantity = quantity;
    }

    public decimal CalculateTotal()
    {
        return Route.Price * Quantity;
    }

    public void PrintTicket()
    {
        Console.WriteLine("--- Билет ---");
        Console.WriteLine($"Маршрут: {Route.From} - {Route.To}");
        Console.WriteLine($"Дата и время: {Route.DateTime}");
        Console.WriteLine($"Количество билетов: {Quantity}");
        Console.WriteLine($"Итого: {CalculateTotal()} руб.");
    }
}
