using System;
using System.Collections.Generic;

namespace bus_ticket_system;

public class PaymentSystem
{
    private List<IPaymentMethod> paymentMethods;

    public PaymentSystem()
    {
        paymentMethods = new List<IPaymentMethod>();
    }

    public void AddPaymentMethod(IPaymentMethod paymentMethod)
    {
        paymentMethods.Add(paymentMethod);
    }

    public void DisplayPaymentMethods()
    {
        Console.WriteLine("Доступные способы оплаты:");
        for (int i = 0; i < paymentMethods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {paymentMethods[i].GetType().Name}");
        }
    }

    public IPaymentMethod GetPaymentMethod(int index)
    {
        if (index >= 1 && index <= paymentMethods.Count)
        {
            return paymentMethods[index - 1];
        }
        return null;
    }
}
