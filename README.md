## General Info
- <b> Objective: </b> Development of an API in .NET 8 using the Builder Design Pattern. The boilerplate of this API was generated using Chat-GPT.

## What are Design Patterns
*From Refactoring Guru*: Design patterns are typical solutions to commonly occurring problems in software design. They are like pre-made blueprints that you can customize to solve a recurring design problem in your code.

Creational design patterns provide various object creation mechanisms, which increase flexibility and reuse of existing code.

## What is the Builder Design Pattern
*From Refactoring Guru*: Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

<b>Pros</b>:
- You can construct objects step-by-step, defer construction steps or run steps recursively.
-  You can reuse the same construction code when building various representations of products.
- *Single Responsibility Principle*. You can isolate complex construction code from the business logic of the product.

<b>Cons</b>:
- The overall complexity of the code increases since the pattern requires creating multiple new classes.


## How this project was created
First, a new .NET WebApi project was started through the CLI:
```
dotnet new webapi -n ProdutoApi
```

Then, a Boilerplate for this project was generated using Chat-GPT. The prompt given was: "Create a simple .NET 8 API based on the Builder Design Pattern". Chat-GPT indicated which entities, controllers and builders were needed for the project. It also indicated a few configurations needed to make sure the controllers were mapped and could run with no issues.

The project didn't compile right away, since the standard .NET Api is built in a slightly different way than what Chat-GPT generated. However, after reading some internet tutorials and doing some modifications to the Controllers, i managed to get it working.

## How to run this project
Make sure you're in the same directory as the root of the project and run the command:

```
dotnet run
```

## References
- [Refactoring Guru - Builder Pattern](https://refactoring.guru/design-patterns/builder);
- [ChatGPT](https://chatgpt.com/);
- [Creating an ASP.NET Core Web API Project Using .NET Core CLI: A Step-by-Step Guide](https://medium.com/c-sharp-programming/creating-an-asp-net-core-web-api-project-using-net-core-cli-a-step-by-step-guide-44699c03c3c5);
- [Tutorial: Create a web API with ASP.NET Core
](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio).