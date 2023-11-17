using EFCore8.PrimitiveCollections;

using MyContext context = new();
context.Database.EnsureCreated();

var user = new User
{
    Name = "Test",
    PhoneNumbers = ["9999999", "8888888"]
};
context.Users.Add(user);
context.SaveChanges();