using System;
using System.Collections.Generic;

namespace bus_ticket_system
{
    class Program
    {
        private static TicketSystem ticketSystem = new TicketSystem();
        private static PaymentSystem paymentSystem = new PaymentSystem();

        public static void Main(string[] args)
        {
            ticketSystem.AddRoute(new Route("Москва", "Санкт-Петербург", new DateTime(2023, 6, 10, 10, 0, 0), 1000));
            ticketSystem.AddRoute(new Route("Москва", "Казань", new DateTime(2023, 6, 12, 12, 0, 0), 800));

            paymentSystem.AddPaymentMethod(new ElectronicWallet("WebMoney"));
            paymentSystem.AddPaymentMethod(new BankCard("Visa"));

            Console.WriteLine("Добро пожаловать в систему продажи билетов на междугородние маршруты!");
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Просмотреть доступные маршруты");
                Console.WriteLine("2. Купить билет");
                Console.WriteLine("3. Выйти");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ticketSystem.DisplayRoutes();
                        break;
                    case "2":
                        ticketSystem.PurchaseTicket(paymentSystem);
                        break;
                    case "3":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}