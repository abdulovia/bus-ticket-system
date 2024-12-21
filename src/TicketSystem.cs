using System;
using System.Collections.Generic;

namespace bus_ticket_system
{
    public class TicketSystem
    {
        private List < Route > routes;
        public TicketSystem()
        {
            routes = new List < Route > ();
        }
        public void AddRoute(Route route)
        {
            routes.Add(route);
        }
        public void DisplayRoutes()
        {
            Console.WriteLine("Доступные маршруты:");
            foreach(var route in routes)
            {
                Console.WriteLine($"ID: {route.Id}, Откуда: {route.From}, Куда: {route.To}, Дата и время: {route.DateTime}, Цена: {route.Price}");
            }
        }
        public void PurchaseTicket(PaymentSystem paymentSystem)
        {
            Console.WriteLine("Введите ID маршрута:");
            int routeId = int.Parse(Console.ReadLine());
            Route selectedRoute = routes.Find(r => r.Id == routeId);
            if (selectedRoute == null)
            {
                Console.WriteLine("Некорректный ID маршрута.");
                return;
            }
            Console.WriteLine("Введите количество билетов:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ оплаты:");
            paymentSystem.DisplayPaymentMethods();
            int paymentMethodIndex = int.Parse(Console.ReadLine());
            IPaymentMethod selectedPaymentMethod = paymentSystem.GetPaymentMethod(paymentMethodIndex);
            if (selectedPaymentMethod == null)
            {
                Console.WriteLine("Некорректный выбор способа оплаты.");
                return;
            }
            Ticket ticket = new Ticket(selectedRoute, quantity);
            selectedPaymentMethod.ProcessPayment(ticket.CalculateTotal());
            Console.WriteLine("Билет успешно приобретен!");
            ticket.PrintTicket();
        }
    }
}