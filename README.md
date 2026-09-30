# dotnet.studies
Some leetcode and basic concepts about dot. net  

# How to know the dotnet version
dotnet --version

# you can also ran 
dotnet --info

# Creating a new console application
dotnet new console

## After creating the console two new files will be created 
- .csproj -> the project configuration 
- Program.cs -> the source code

# Printing some content into the console
## Just use Console.WriteLine("put your text here")
Console.WriteLine("Hey there!!")

# Running the App 
dotnet run 


-- 

# Variables 
string name = 'Elder'; 


# .NET Backend — Core Concepts

## 1. Dependency Injection - DI

**define a abstraction**
```C#
public interface INotificationService
{
    Task SendAsync(string message);
}
```

**Create the implementation**
```C#
public class EmailNotificationService : INotificationService
{
    public Task SendAsync(string message)
    {
        Console.WriteLine($"Sending email: {message}");

        return Task.CompletedTask;
    }
}
```

**configure the program.cs**
```C#
builder.Services.AddScoped<
    INotificationService,
    EmailNotificationService>();
```

**use the implementation this way**
```C#
public class OrderService
{
    private readonly INotificationService _notificationService;

    public OrderService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public async Task CreateOrderAsync()
    {
        // Create order...

        await _notificationService.SendAsync("Order created");
    }
}
``` 

Why DI is useful
- Easy to test
- Easier replacement of implementations 
- Cleaner Architecture 
