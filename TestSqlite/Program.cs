// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using TestSqlite;



var a = new DbContextOptionsBuilder<ApplicationContext>();

a.UseSqlite("Data Source=Booking.db;", sqliteOptionsAction =>
{
    sqliteOptionsAction.CommandTimeout(30);
});

var context = new ApplicationContext(a.Options);



if (!context.Users.Any())
{
    context.Users.Add(new User()
    {
        FirstName = "Artiom",
        SecondName = "Savko",
        Email = "savik@yandex.ru",
        Address = "Pupkina str. Minsk, Prititskogo 12-3"
    });
    context.Users.Add(new User()
    {
        FirstName = "Dmitro",
        SecondName = "Pupinin",
        Email = "DiPup@yandex.ru",
        Address = "Pushkinskaya str. Minsk, 10-15"
    });
    context.Users.Add(new User()
    {
        FirstName = "Vladislav",
        SecondName = "Kamenatski",
        Email = "vk@yandex.ru",
        Address = "no address..."
    });
    context.Users.Add(new User()
    {
        FirstName = "Bomz",
        SecondName = "Bomber",
        Email = "none@mail.ru",
        Address = "Address? What is it?"
    });
    context.SaveChanges();
}

foreach (var user in context.Users)
{
    Console.WriteLine($"{user.FirstName} {user.SecondName}");
}
