

using dotnet_ef_core_example;


InsertData();
PrintData();

static void InsertData()
{
    using (var context = new DatabaseContext())
    {
        context.Database.EnsureCreated();

        var newFriend = new Contact()
        {
            FirstName = "first name",
            LastName = "last name",
            Phone = "1234",
            Description = "Desc"
        };
        context.Contacts.Add(newFriend);
        context.SaveChanges();
    }
}

static void PrintData()
{
    using (var context = new DatabaseContext())
    {
        var contact = context.Contacts.First();
        Console.WriteLine(contact.FirstName);
        Console.WriteLine(contact.LastName);
    }
}
