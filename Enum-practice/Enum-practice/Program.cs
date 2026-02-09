/*
Crie um uma strutura enum e relacione ela com um atributo da classe
Order na instanciação.
*/

using Enum_practice.Entities;
using Enum_practice.Entities.Enums;

Order order = new Order
{
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order.ToString());