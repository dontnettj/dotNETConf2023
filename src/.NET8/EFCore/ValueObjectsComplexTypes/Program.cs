using EFCore8.ValueObjectsComplexTypes;

using MyContext context = new();
context.Database.EnsureCreated();

var complexUser = new User
{
    Name = "Test",
    Contact = new Contact
    {
        Email = "text@email.com",
        PhoneNumber = "99999999"
    }
};
context.Users.Add(complexUser);
context.SaveChanges();