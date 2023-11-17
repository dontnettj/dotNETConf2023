// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;


#region Primitive collections

using EFCore8.PrimitiveCollections.MyContext context = new EFCore8.PrimitiveCollections.MyContext();
context.Database.EnsureCreated();

var user = new EFCore8.PrimitiveCollections.User
{
    Name = "Test",
    PhoneNumbers = ["9999999", "8888888"]
};
context.Users.Add(user);
context.SaveChanges();

#endregion

#region SqlRawExample

using EFCore8.SQLRawQueriesForUnmappedTypes.MyContext sqRawContext = new EFCore8.SQLRawQueriesForUnmappedTypes.MyContext();
context.Database.EnsureCreated();

var order = new EFCore8.SQLRawQueriesForUnmappedTypes.Order
{
    Contents = "Order for the product",
    Price = 100,
    Quantity = 300
};
sqRawContext.Orders.Add(order);
sqRawContext.SaveChanges();

var summaries =
     context.Database.SqlQuery<EFCore8.SQLRawQueriesForUnmappedTypes.MyOrderReport>(
            @$"SELECT o.Contents AS Title, o.Price * o.Quantity as TotalPrice
            FROM Orders AS o")
        .ToList();

Console.Read();

#endregion

#region ValueObjectsComplexTypes

using EFCore8.ValueObjectsComplexTypes.MyContext valueObjectsContext = new EFCore8.ValueObjectsComplexTypes.MyContext();
valueObjectsContext.Database.EnsureCreated();

var complexUser = new EFCore8.ValueObjectsComplexTypes.User
{
    Name = "Test",
    Contact = new EFCore8.ValueObjectsComplexTypes.Contact
    {
        Email = "text@email.com",
        PhoneNumber = "99999999"
    }
};
valueObjectsContext.Users.Add(complexUser);
valueObjectsContext.SaveChanges();

#endregion