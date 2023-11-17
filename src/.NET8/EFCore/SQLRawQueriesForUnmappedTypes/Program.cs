using EFCore8.SQLRawQueriesForUnmappedTypes;
using Microsoft.EntityFrameworkCore;

using MyContext sqRawContext = new();
sqRawContext.Database.EnsureCreated();

var order = new Order
{
    Contents = "Order for the product",
    Price = 100,
    Quantity = 300
};
sqRawContext.Orders.Add(order);
sqRawContext.SaveChanges();

var summaries =
     sqRawContext.Database.SqlQuery<MyOrderReport>(
            @$"SELECT o.Contents AS Title, o.Price * o.Quantity as TotalPrice
            FROM Orders AS o")
        .ToList();

Console.Read();